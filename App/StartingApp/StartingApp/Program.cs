using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartingApp
{
  public class Program
  {
    public static int CurrentID = 1;
    public static void Main()
    {
      var query = new StringBuilder();
      InsertRow(CurrentID, 0, "1", query);
      AddChildren(CurrentID, 1, "1", query);
    }

    public static void InsertRow(int currentID, int parentID, string route, StringBuilder sb)
    {

    }

    public static void AddChildren(int currentID, int parentID, string route, StringBuilder sb)
    {
      Console.WriteLine($"CurrentID {currentID} Parent {parentID} route {route}");
      if (currentID < 10)
      {
        for (int i = 0; i < 3; i++)
        {
          CurrentID++;
          var currentRoute = route + '/' + currentID;
          AddChildren(CurrentID, parentID, currentRoute, sb);
        }
      }
      else
      {
        var a = 1;
      }
    }
  }
}
