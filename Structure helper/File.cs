using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Structure_Helper
{
    public static class File
    {
        public static void LoadFile(string fileName)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                Program.CurrentJob = new Job(Path.GetFileNameWithoutExtension(fileName));
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    if (line == "***")
                        break;

                    Structure sc = new Structure();
                    Program.CurrentJob.Structures.Add(sc);

                    string[] arr = line.Split(',');
                    sc.Shot = arr[0];
                    sc.Label = arr[1];
                    sc.Type = (StructureType)Enum.Parse(typeof(StructureType), arr[2]);
                    sc.Northing = float.Parse(arr[3]);
                    sc.Easting = float.Parse(arr[4]);
                    sc.Elevation = float.Parse(arr[5]);
                    int n = Convert.ToInt32(arr[6]);

                    for (int i = 0; i < n; i++)
                    {
                        PipeEnd p = new PipeEnd(sc);
                        sc.Pipes.Add(p);
                        line = reader.ReadLine();
                        arr = line.Split(',');

                        p.ID = ((char)(i + 'A')).ToString();
                        p.Invert = float.Parse(arr[0]);
                        p.Flow = (Flow)Enum.Parse(typeof(Flow), arr[1]);
                        p.Direction = float.Parse(arr[2]);
                        p.Diameter = float.Parse(arr[3]);
                        p.Type = (PipeType)Enum.Parse(typeof(PipeType), arr[4]);
                    }
                }

                while ((line = reader.ReadLine()) != null)
                {
                    string[] arr = line.Split(',');
                    Connection c = new Connection();
                    c.upperStructure = Program.CurrentJob.Structures.Find(x => x.Shot == arr[0]);
                    c.lowerStructure = Program.CurrentJob.Structures.Find(x => x.Shot == arr[1]);
                    c.upperEnd = c.upperStructure.Pipes.Find(x => x.ID == arr[2]);
                    c.lowerEnd = c.lowerStructure.Pipes.Find(x => x.ID == arr[3]);

                    Program.Connections.Add(c);
                }
            }
        }

        public static void LoadShotFile(string shotFileName)
        {
            using (StreamReader reader = new StreamReader(shotFileName))
            {
                string line;
                Program.CurrentJob = new Job(Path.GetFileNameWithoutExtension(shotFileName));

                while ((line = reader.ReadLine()) != null)
                {
                    string[] arr = line.Split(',');
                    string[] typeLabel = arr[4].Split('-');

                    //check if shot is structure, if so, add structure and info
                    //arr = shot, northing, easting, elevation,type-label
                    if (Enum.IsDefined(typeof(StructureType), typeLabel[0]))
                    {
                        Structure s = new Structure();
                        Program.CurrentJob.Structures.Add(s);
                        s.Shot = arr[0];
                        s.Northing = float.Parse(arr[1]);
                        s.Easting = float.Parse(arr[2]);
                        s.Elevation = float.Parse(arr[3]);
                        if(typeLabel.Length>1)
                            s.Label = typeLabel[1];
                        s.Type = (StructureType)Enum.Parse(typeof(StructureType), typeLabel[0]);
                    }
                }
            }
        }

        public static void MergeFiles(string file, string shotFile)
        {
            File.LoadFile(file);

            using (StreamReader reader = new StreamReader(shotFile))
            {
                string line;
                Program.CurrentJob = new Job(Path.GetFileNameWithoutExtension(shotFile));

                while ((line = reader.ReadLine()) != null)
                {
                    string[] arr = line.Split(',');
                    string[] typeLabel = arr[4].Split('-');

                    //check if shot is structure, if so, add structure and info
                    //arr = shot, northing, easting, elevation,type-label
                    if (Enum.IsDefined(typeof(StructureType), typeLabel[0]))
                    {
                        Structure s;
                        //check if label exists, if so info to existing Structure, else create new
                        if (Program.CurrentJob.Structures.Any(x => x.Label == typeLabel[1]) && typeLabel.Length > 1)
                        {
                            s = Program.CurrentJob.Structures.Find(x => x.Label == typeLabel[1]);
                        }
                        else
                        {
                            s = new Structure();
                            Program.CurrentJob.Structures.Add(s);
                        }

                        s.Shot = arr[0];
                        s.Northing = float.Parse(arr[1]);
                        s.Easting = float.Parse(arr[2]);
                        s.Elevation = float.Parse(arr[3]);                        
                        s.Type = (StructureType)Enum.Parse(typeof(StructureType), typeLabel[0]);
                    }
                }
            }

        }

        public static void SaveJobFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName, false))
            {
                foreach (Structure sc in Program.CurrentJob.Structures)
                {
                    string s = String.Format("{0},{1},{2},{3},{4},{5},{6}", sc.Shot, sc.Label, sc.Type.ToString(), sc.Northing, sc.Easting, sc.Elevation, sc.Pipes.Count.ToString());
                    writer.WriteLine(s);

                    //to sql
                    /*
                    var scdb = new StructureDB();
                    scdb.Shot = sc.Shot;
                    scdb.Label = sc.Label;
                    scdb.Type = sc.Label.ToString();
                    scdb.Northing = sc.Northing;
                    scdb.Easting = sc.Easting;
                    scdb.Elevation = sc.Elevation;
                    Program.DB.StructureDBs.Add(scdb);
                    Program.DB.SaveChanges();
                     * */

                    foreach (PipeEnd p in sc.Pipes)
                    {
                        s = string.Format("{0},{1},{2},{3},{4}", p.Invert.ToString(), p.Flow.ToString(), p.Direction.ToString(), p.Diameter.ToString(), p.Type.ToString());
                        writer.WriteLine(s);
                    }
                }

                writer.WriteLine("***");

                foreach (Connection c in Program.Connections)
                {
                    //upperStructure shot, lowerStructure shot, upperPipe ID, lowerPipe ID

                    string con = string.Format("{0},{1},{2},{3}", c.upperStructure.Shot, c.lowerStructure.Shot, c.upperEnd.ID, c.lowerEnd.ID);
                    writer.WriteLine(con);
                }
            }
        }
    }
}
