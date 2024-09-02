using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.TeamworkProjects
{
    internal class Program
    {
        /*
         It's time for the teamwork projects and you are responsible for gathering the teams. First, you will receive an integer – the count of the teams you will have to register. You will be given a user and a team, separated with "-". The user is the creator of the team. For every newly created team you should print a message:
        "Team {teamName} has been created by {user}!".
        Next, you will receive user with a team, separated with "->", which means that the user wants to join that team. Upon receiving the command: "end of assignment", you should print every team, ordered by the count of its members (descending) and then by name (ascending). For each team, you have to print its members sorted by name (ascending). However, there are several rules:
        If user tries to create a team more than once, a message should be displayed:
        "Team {teamName} was already created!"
        A creator of a team cannot create another team – the following message should be thrown:
        "{user} cannot create another team!"
        If user tries to join a non-existent team, a message should be displayed:
        "Team {teamName} does not exist!"
        A member of a team cannot join another team – the following message should be thrown:
        "Member {user} cannot join team {team Name}!"
        In the end, teams with zero members (with only a creator) should disband and you have to print them ordered by name in ascending order.
        Every valid team should be printed ordered by name (ascending) in the following format:
        "{teamName}- {creator}-- {member}…"
       
        
        Input
2
John-PowerPuffsCoders
Tony-Tony is the best
Peter->PowerPuffsCoders
Tony->Tony is the best
end of assignment


        Output

        Team PowerPuffsCoders has been created by John!
        Team Tony is the best has been created by Tony!
        Member Tony cannot join team Tony is the best!
        PowerPuffsCoders
        - John
        -- Peter
        Teams to disband:
        Tony is the best
         */
        static void Main(string[] args)
        {
            int countOfTeams = int.Parse(Console.ReadLine());

            List<Teams> team = new List<Teams>();

            for (int i = 0; i < countOfTeams; i++)
            {
                string[] teamNames = Console.ReadLine().Split("-").ToArray();
                string teamCreator = teamNames[0];
                string teamName = teamNames[1];

                if (team.Any(t => t.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (team.Any(t => t.Creator == teamCreator))
                {
                    Console.WriteLine($"{teamCreator} cannot create another team!");
                }
                else
                {
                    Teams newTeam = new Teams(teamCreator, teamName);
                    team.Add(newTeam);
                    Console.WriteLine($"Team {teamName} has been created by {teamCreator}!");
                }
            }

            string input;
            while ((input = Console.ReadLine()) != "end of assignment")
            {
                string[] teamNames = input.Split("->").ToArray();
                string userJoiningTeam = teamNames[0];
                string teamName = teamNames[1];

                Teams existingTeam = team.FirstOrDefault(t => t.TeamName == teamName);
                bool userIsMember = team.Any(t => t.Members.Contains(userJoiningTeam)) 
                    || team.Any(t => t.Creator == userJoiningTeam);

                if (existingTeam == null)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (userIsMember)
                {
                    Console.WriteLine($"Member {userJoiningTeam} cannot join team {teamName}!");
                }
                else
                {
                    existingTeam.Members.Add(userJoiningTeam);
                }
            }

            var validTeams = team.Where(t => t.Members.Count > 0)
                                 .OrderByDescending(t => t.Members.Count)
                                 .ThenBy(t => t.TeamName)
                                 .ToList();

            var disbandedTeams = team.Where(t => t.Members.Count == 0)
                                     .OrderBy(t => t.TeamName)
                                     .ToList();

            foreach (var t in validTeams)
            {
                Console.WriteLine(t.TeamName);
                Console.WriteLine($"- {t.Creator}");
                foreach (var member in t.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var t in disbandedTeams)
            {
                Console.WriteLine(t.TeamName);
            }
        }
    }
}
