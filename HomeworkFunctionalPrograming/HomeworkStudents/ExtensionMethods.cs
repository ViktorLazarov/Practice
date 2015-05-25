using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class ExtensionMethods
{
    public static IList<Student> ExtensionCount(this IList<Student> marks)
    {
        var result =
            from mark in marks
            where (mark.Marks.Count(x => x == 2) == 2)
            select mark;
        return result.ToList();

    }
}

