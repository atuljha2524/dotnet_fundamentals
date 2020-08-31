public class Family
    {
        public void Visit(Person obj) {

            obj.Friendly();
            obj.Laughter();
            obj.Mature();
            obj.Professional();//hidden
        }
    }

    public class Friend
    {
        public void Hangout(Person obj) {
            obj.Anger();
            obj.Friendly();
            obj.Laughter();
            obj.Mature();
            obj.Professional();//Hidden
        
        }

    }

    public class Office
    {
        public void Dowork(Person obj)
        {
            obj.Professional();
            obj.Mature();
            obj.Anger();//hidden
            obj.Friendly();//hidden
           

        }
    }

   public interface OfficePerson
   {
       void Professional();
       void Mature();
   }

   public interface FriendlyPerson
   {
        void Friendly();
       void Anger();
       void Laughter();
   }
   public interface FamilyPerson
   {
        void Mature();
        void Anger();
        void Laughter();
   }
    public class Person : Officeperson, FriendlyPerson, FamilyPerson
    {

        public void Friendly() {Console.WriteLine("Friendle Behavior"); }
        public void Professional() { }
        public void Anger() { }

        public void Laughter() { }

        public void Mature() { }


    }

    public class Program
    {
        public static void Main()
        {
            FamilyPerson _singlePerson = new Person();

            Family __familiyVisit = new Family();
            __familiyVisit.Visit(_singlePerson);
            
            OfficePerson _singlePerson = new Person();
            Office _workContext = new Office();
            _workContext.Dowork(_singlePerson);
            
            FriendlyPerson _singlePerson = new Person();
            Friend _friendCircle = new Friend();
            _friendCircle.Hangout(_singlePerson);
        }
    }
