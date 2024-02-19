namespace LINQ1{
    internal class PRogram {
        static void Main(string[] args){
            Console.Title = "LINQ1";



//data source 
string[] students = {"Ahmed", "Samy, "Ali", "Mohamed", "Eslam", "Reda"}

//LINQ 
var Result = from student in students 
where student.Contains("d") || student.Contains("D")
//orderby student ascending 
orderby student descending 
select student;

//read 
foreach (var item in Result){
    Console.WriteLine(item)
}
        }
    }
}