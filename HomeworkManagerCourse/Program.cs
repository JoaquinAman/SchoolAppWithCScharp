// See https://aka.ms/new-console-template for more information
using HomeworkManagerCourse;
using HomeworkManagerCourse.printer;
using System.Xml.Linq;


School school = new ();

IOption optionPrintMenu = new OptionPrintMenu(0);

Printer printer = new Printer();

printer.ListOfOptions.Add(optionPrintMenu);

printer.printCommand(0, school);
