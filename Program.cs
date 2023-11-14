using System.Diagnostics;
using System.IO;

ShowPapka("/");

void ShowPapka(string s)
{
    while (true)
        {
        try
        {

            Console.Clear();
            string[] paths = Directory.GetDirectories(s);
            foreach (string path in paths)
            {
                Console.WriteLine(" " + path);
            }

            string[] paths1 = Directory.GetFiles(s);
            foreach (string path1 in paths1)
            {
                Console.WriteLine(" " + path1);
            }



            int pos = strelocki.Show(0, paths.Length - 1 + paths1.Length);
            if (pos == -1)
                return;
            if (pos <= paths.Length)
                ShowPapka(paths[pos]);
            if (pos >= paths.Length)
            {
                Process.Start(new ProcessStartInfo {FileName= paths1[pos - paths.Length],UseShellExecute = true});

            }
            {

                DirectoryInfo pathInfo = new DirectoryInfo(paths[pos]);
                Console.WriteLine($"   {paths[pos]}                    {pathInfo.CreationTime}          {pathInfo.Extension}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        
    }
}

