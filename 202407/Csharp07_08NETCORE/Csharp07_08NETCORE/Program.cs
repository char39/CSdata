//namespace Csharp07_08NETCORE
//{
//    class Base
//    {
//        protected string Name;
//        protected int PhoneNumber;
//        public Base()
//        {
//            Console.WriteLine("Void Base(0)");
//            Name = string.Empty;
//        }
//        public Base(string Name)
//        {
//            Console.WriteLine("Base(1[Name])");    // Base 클래스의 생성자. 객체 생성 시 출력
//            this.Name = Name;
//        }
//        public Base(string Name, int PhoneNumber) : this(Name)
//        {
//            Console.WriteLine("Base(2[Name], [PhoneNumber])");
//            this.PhoneNumber = PhoneNumber;
//        }
//        ~Base()
//        {
//            Console.WriteLine("~Base()");   
//        }
//    }
//    class Derived : Base
//    {
//        public Derived()
//        {
//            Console.WriteLine("Void Derived(0)");
//        }
//        public Derived(string Name) : base(Name)    // Base 클래스의 생성자 호출
//        {
//            Console.WriteLine("Derived(1[Name])");
//            this.Name = Name;
//        }
//        public Derived(string Name, int PhoneNumber) : base(Name, PhoneNumber)
//        {
//            // 자식클래스는 반드시 부모클래스의 생성자를 호출하여 초기화 해야한다.
//            Console.WriteLine("Derived(2[Name], [PhoneNumber])");
//            this.PhoneNumber = PhoneNumber;
//        }
//        public void SetPrint()
//        {
//            Console.WriteLine("Name: {0}, PhoneNumber: {1}", Name, PhoneNumber);
//        }
//        ~Derived()
//        {
//            Console.WriteLine("~Derived()");
//        }
//    }

//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Derived derived = new Derived("엄준식", 1234);    // Derived 클래스의 객체 생성
//            Derived derived1 = new Derived("엄홍길");
//            Derived derived2 = new Derived();

//            // 클래스 상속으로 인해 코드의 재사용성이 높아지고, 유지보수가 용이해진다.
//            // 프로젝트가 커질수록 클래스 상속을 통해 코드를 최적화 할 수 있다.
//            // 자식클래스가 상속을 요구하면 부모클래스는 반드시 초기화 되어야 하지만,
//            // 상속이 안되도록 하려면 클래스 앞에 sealed 키워드를 사용하면 된다.
//        }
//    }
//}
