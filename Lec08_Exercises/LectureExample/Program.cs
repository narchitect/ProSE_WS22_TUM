using System.Linq;
namespace Program

{
    public class People
    {
        public int Age { get; set; }
        public decimal Income { get; set; }
    }


    // ---------03. Using Extension Methods
    // * ExtensionClass should be defined in the top level static class in a namespace. 
    static public class ExtensionClass
    {
        // 여기 Func generic delegate를 쓴 이유
        // fillterPeople method는 dataset 과 어떤 method를 받는데, 어떠한 메소드는 People 클래스를 parameter, return 값은 bool로 받음
        static public List<People> FilterPeople(this List<People> dataset, Func<People, bool> filterFunction)
        {
            var bucket = new List<People>();
            foreach (var p in dataset)
            {
                // 그 메소드가 p라는 인스턴스를 받아드리고 그 값이 bool이기때문에 
                if (filterFunction(p))
                {
                    bucket.Add(p);
                }
            }
            return bucket;
        }
    }


    internal class Program
    {
        public static bool ReturnBool(People par1)
        {
            if (par1.Age > 30)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main01(string[] arg)
        {

            var dataset = new List<People>
            {
                new People {Age = 45, Income = 35000},
                new People {Age = 15, Income = 45000},
                new People {Age = 35, Income = 25000},
                new People {Age = 55, Income = 15000},
                new People {Age = 5, Income = 5000},
                new People {Age = 25, Income = 135000}
            };

            //-------------03 using ExtensionMethod
            // 여기 람다식에서는 데이터타입을 지정할 필요가 없는데 이유는 Func에서 이미 데이터 형식을 지정해줬기때문에 참조 가
            var bucket = dataset.FilterPeople(people => people.Age > 30);

            //-------------01 old way to create a database
            //var bucket = new List<People>();
            //foreach (var p in dataset)
            //{
            //    if (p.Age > 30)
            //    {
            //        bucket.Add(p);
            //    }    
            //};
            //    foreach (var p in bucket)
            //    {
            //        Console.WriteLine("The age is " + p.Age.ToString());
            //    }
            //}

            //-------------02 create a method to filter dataset
            //static List<People> FilterPeople (List<People> dataset)
            //{
            //    var bucket = new List<People>();
            //    foreach (var p in dataset)
            //    {
            //        if (p.Age > 30)
            //        {
            //            bucket.Add(p);
            //        }
            //    }
            //    return bucket;
            //}
            //    var bucket = FilterPeople(dataset);
            //    foreach (var p in bucket)
            //    {
            //        Console.WriteLine("The age is " + p.Age.ToString());
            //    }
            //}

            //--------------04. Using Linq

            var bucket02 = dataset.Where(p => p.Age > 30).Where(p => p.Income > 50000);
        }
    }
}