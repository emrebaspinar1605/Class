namespace Class
{
    

    public class Program
    {
         static void Main(string[] args)
        {
            Worker worker1=new Worker();
            worker1.Ad="Emre";
            worker1.Soyad="Başpınar";
            worker1.No=25442;
            worker1.Departman="Back-end";

            Worker worker2=new Worker{
                Ad="Enes",
                Soyad="Başpınar",
                No=25441,
                Departman="Front-end"
            };
            worker1.WorkerInformation();
            Console.WriteLine("*******");
            worker2.WorkerInformation();
        }
    }
    class Worker
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;
        public void WorkerInformation()
         {
            Console.WriteLine("Çalışanın Adı:{0}",Ad); 
            Console.WriteLine("Çalışanın Soyadı:{0}",Soyad); 
            Console.WriteLine("Çalışanın Numarası:{0}",No); 
            Console.WriteLine("Çalışanın Departmanı:{0}",Departman); 
         }

    }
}