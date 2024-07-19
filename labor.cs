using System;

public class Program
{
    enum ColumnType
    {
        ColTitle,
        ColAuthor,
        ColYear
    }

    public static void HandleColumn(ColumnType column)
    {
        switch (column)
        {
            case ColumnType.ColTitle:
                Console.WriteLine("Handling title column");
                break;
            case ColumnType.ColAuthor:
                Console.WriteLine("Handling author column");
                break;
            case ColumnType.ColYear:
                Console.WriteLine("Handling year column");
                break;
            default:
                Console.WriteLine("Unknown column type");
                break;
        }
    }

    public static void Main()
    {
        HandleColumn(ColumnType.ColTitle);
        HandleColumn(ColumnType.ColAuthor);
        HandleColumn(ColumnType.ColYear);
    }
}
