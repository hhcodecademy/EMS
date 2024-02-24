namespace EMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            List<Student> students = new List<Student>();

            List<Employee> employees = new List<Employee>();
            Person h1= new Teacher();
            h1.Name = "Huseyn";
            persons.Add(h1);

            Person n1 = new Mentor();
            persons.Add(n1);
            n1.Name = "Nicat";

            Person u = new Student();
            persons.Add(u);
            u.Name = "Ugur";

            Person se = new Student();
            persons.Add(se);
            se.Name = "Semra";


            Person emp = new Employee();
            persons.Add(emp);
            emp.Name = "Nermin";

            Person st = new Staff();
            persons.Add(st);
            st.Name = "Gulsen";

            foreach (Person p in persons)
            {
                p.come();
              
                if (p is Employee employee)
                {

                    employees.Add(employee);
                }
                if (p is Student student)
                {

                    students.Add(student);
                }

            }

            Console.WriteLine("Isciler....");

            foreach (var item in employees)
            {
                Console.WriteLine(item.Name);

                if (item is Teacher teacher) {
                   item.Work(); 
                }
                if (item is Staff staff)
                {
                    item.Work();
                }
            }
            Console.WriteLine("Telebeler....");

            foreach (var item in students)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
