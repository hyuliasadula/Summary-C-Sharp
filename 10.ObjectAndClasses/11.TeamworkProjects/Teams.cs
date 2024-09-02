using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace _11.TeamworkProjects
{
    internal class Teams
    {
        public string Creator { get; set; }
        public string TeamName { get; set; }
        public List<string> Members { get; set; }

        public Teams(string creator, string teamName)
        {
            Creator = creator;
            TeamName = teamName;
            Members = new List<string>();
        }
    }
}
