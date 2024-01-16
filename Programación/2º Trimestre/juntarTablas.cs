namespace juntarTablas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };
            int[] b = { 1, 2, 3 };
            int[] c = { };

            Console.WriteLine("Tabla c: ");
            merge(a, b);
            mostrar(c);
        }

        public static int[] Concat(int[] a, int[] b)
        {
            int i = 0;
            int k = 0;
            int[] c = { };

            while (i < a.Length)
            {
                c[k] = a[i];
                i++;
                k++;
            }

            while (i < b.Length)
            {
                c[k] = b[i];
                i++;
                k++;
            }
            return c;
        }

        public static int[] merge (int[] a, int[] b)
        {
            int i = 0;
            int j = 0;
            int k = 0;
            int max = a.Length + b.Length;
            int[] c = new int[max];
            
            while (i < a.Length && j < b.Length)
            {
                if (a[i] <= b[j])
                {
                    c[k] = a[i];
                    i++;
                } 
                else
                {
                    c[k] = b[j];
                    j++;
                }
                k++;
            }
            while (i < a.Length)
            {
                c[k] = a[i];
                i++;
                k++;
            }

            while (i < b.Length)
            {
                c[k] = b[i];
                i++;
                k++;
            }
            return c; //merge
        }

        public static void mostrar(int[] c)
        {
            int i = 0;
            int max = a.Length + b.Length;

            while (c.Length <= max)
            {
                Console.Write(c[i]);
                i++;
            }
            Console.WriteLine(c);
        }
    }
}
