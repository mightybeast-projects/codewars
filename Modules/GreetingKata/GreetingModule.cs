using System.Text;

namespace GreetingKata;

public class GreetingModule
{
    private string[] inputNames;
    private List<string> normalNames;
    private List<string> shoutedNames;
    private StringBuilder result;

    public string Greet(params string[] names)
    {
        if (names == null)
            return "Hello, my friend.";

        inputNames = names;

        if (names.Count<string>() == 1)
            return GreetOnePerson(inputNames[0]);
        else
            return GreetSeveralPeople();
    }

    private string GreetOnePerson(string name)
    {
        if (name.ToUpper() == name) return "HELLO " + name + "!";

        return "Hello, " + name + ".";
    }

    private string GreetSeveralPeople()
    {
        result = new StringBuilder("Hello, ");

        AppendSeveralPeopleToResult();

        return result.ToString();
    }

    private void AppendSeveralPeopleToResult()
    {
        SplitInputNames();
        FormatNormalNames();
        FormatShoutedNames();
    }

    private void SplitInputNames()
    {
        InitializeLists();

        foreach (string name in inputNames)
        {
            if (name == name.ToUpper())
            {
                shoutedNames.Add(name);
                continue;
            }

            if (name.Contains(","))
            {
                if (name.Contains("\""))
                {
                    normalNames.Add(name.Replace("\"", ""));
                    continue;
                }

                AddCommaSeparatedNames(name);
                continue;
            }

            normalNames.Add(name);
        }
    }

    private void FormatNormalNames()
    {
        int namesSize = normalNames.Count();

        for (int i = 0; i < namesSize; i++)
        {
            string name = normalNames[i];

            if (namesSize > 2)
            {
                if (i != 0)
                {
                    if (i == namesSize - 1)
                        result.Append(", and ");
                    else
                        result.Append(", ");
                }
            }
            else if (i != 0)
                result.Append(" and ");

            result.Append(normalNames[i]);
        }

        result.Append(".");
    }

    private void FormatShoutedNames()
    {
        if (shoutedNames.Any<string>())
            foreach (string shoutedName in shoutedNames)
                result.Append(" AND HELLO " + shoutedName + "!");
    }

    private void InitializeLists()
    {
        normalNames = new List<string>();
        shoutedNames = new List<string>();
    }

    private void AddCommaSeparatedNames(string names)
    {
        string[] commaSeparatedNames = names.Split(", ");
        normalNames.Add(commaSeparatedNames[0]);
        normalNames.Add(commaSeparatedNames[1]);
    }
}