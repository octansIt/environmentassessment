using System.Collections.Generic;
using EnvironmentAssessment.Common.Inventory;

namespace EnvironmentAssessment.Database
{
    internal class CDatabaseEntry
    {
        public string Accessed { get; internal set; }
        public string Attributes { get; internal set; }
        public string Created { get; internal set; }
        public string Id { get; internal set; }
        public string Name { get; internal set; }
        public string Parent { get; internal set; }
        public string Reference { get; internal set; }
        public string Type { get; internal set; }
    }
}