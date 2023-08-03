namespace Test;

public class AttributesTest
{
    
    public static void testAttributes()
    { 
        Update[] updates =
        {
            new Update(1, "test1"),
            new Update(2, "test2"),
            new Update(3, "test3"),
            new Update(4, "test4"),
        };
        UpdatePro.Download(updates);
        UpdatePro.Install(updates);
    }

    class UpdatePro
    {
        [Obsolete("this method will be tested")]
        public static void Download(Update[] updates)
        {
            for (int i = 0; i < updates.Length; i++)
            {
                Console.WriteLine($"Downloading {updates[i]}");
                System.Threading.Thread.Sleep(750);
            }
        }
        public static void Install(Update[] updates)
        {
            for (int i = 0; i < updates.Length; i++)
            {
                Console.WriteLine($"Install {updates[i]}");
                System.Threading.Thread.Sleep(750);
            }
        }

        public static void DownloadAndInstall()
        {
            
        }

    }
    class Update
    {
        private int no;
        private string title;

        public Update(int no, string title)
        {
            this.no = no;
            this.title = title;
        }

        public override string ToString()
        {
            return $"{no} - {title}";
        }
    }
}