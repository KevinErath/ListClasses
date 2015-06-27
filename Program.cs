using System;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

internal class Program
{
    private static void Main()
    {
        var tree = CSharpSyntaxTree.ParseText(
            @"using System; 
            class Program
            { 
                static void Main() 
                { 
                    Console.WriteLine(""Hallo, Welt!""); 
                } 
            }");
        var root = tree.GetRoot();
        foreach (var node in root.DescendantNodes().OfType<ClassDeclarationSyntax>())
        {
            Console.WriteLine(node.Identifier);
        }
    }
}