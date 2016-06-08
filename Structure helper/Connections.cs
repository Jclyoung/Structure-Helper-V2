using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Structure_Helper
{
    public struct Connection
    {
        public string Name
        {
            get { return string.Format("({0},{1})", upperStructure.Shot, lowerStructure.Shot); }
        }
        public PipeEnd upperEnd, lowerEnd;
        public Structure upperStructure, lowerStructure;
    }

    public class Connections : List<Connection>
    {
        public Connections()
        {

        }

        public void Connect(PipeEnd pipe1, PipeEnd pipe2)
        {
            Connection c = new Connection();
            if (pipe1.Flow == Flow.In)
            {
                c.lowerEnd = pipe1;
                c.lowerStructure = pipe1.ParentStructure;
                c.upperStructure = pipe2.ParentStructure;
                c.upperEnd = pipe2;
            }
            else if (pipe1.Flow == Flow.Out)
            {
                c.upperEnd = pipe1;
                c.upperStructure = pipe1.ParentStructure;
                c.lowerStructure = pipe2.ParentStructure;
                c.lowerEnd = pipe2;
            }
            this.Add(c);
            //still need to allow picking of other pipe
        }

        public void Connect(Structure structure1, Structure structure2)
        {

        }
    }
}