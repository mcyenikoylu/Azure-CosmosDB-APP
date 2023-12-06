namespace license.cosmosdb;

public class LicenseKeyGenerator
{
    public static string? LicenseKey { get; set; }

    public static string LicenseGenerate()
    {
        var rand = new Random();
        string key = "";
        string[] randomKey = { "", "", "", "", "", "", "" };
        bool keyLoop = true;
        while (keyLoop)
        {
            int m = 0;
            for (int i = 0; i <= 6; i++)
            {
                int s = rand.Next(1, 9);
                randomKey[i] = s.ToString();
                //Console.Write("{0,8:N0}", s);
                m = m + s;
            }

            if (m % 7 == 0)
            {
                key = rand.Next(1, 9).ToString() + rand.Next(1, 9).ToString() + rand.Next(1, 9).ToString() + randomKey[0].ToString() +
                '-' + randomKey[1].ToString() + randomKey[2].ToString() + rand.Next(1, 9).ToString() + randomKey[3].ToString() +
                '-' + rand.Next(1, 9).ToString() + randomKey[4].ToString() + randomKey[5].ToString() + randomKey[6].ToString();
                Console.WriteLine("{0}:{1}", m, key);
                keyLoop = false;
            }
        }

        LicenseKey = key;

        return LicenseKey;
    }
}