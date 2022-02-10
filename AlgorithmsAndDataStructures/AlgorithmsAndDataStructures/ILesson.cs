using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures
{
    interface ILesson
    {
        int Id { get; }
        string Description { get; }
        void RunLesson();
        

    }
}
