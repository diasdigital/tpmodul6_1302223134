using tpmodul6_1302223134;

SayaTubeVideo STV = new SayaTubeVideo("Tutorial Design By Contract – Muhammad Dias Adani");
STV.PrintVideoDetails();
STV.IncreasePlayCount(5);
STV.PrintVideoDetails();

/*Tes prekondisi title > 100 karakter
SayaTubeVideo STV2 = new SayaTubeVideo("" +
    "1234567890" +
    "1234567890" +
    "1234567890" +
    "1234567890" +
    "1234567890" +
    "1234567890" +
    "1234567890" +
    "1234567890" +
    "1234567890");
*/

// Tes exception
for (int i = 0; i < 215; i++)
{
    STV.IncreasePlayCount(10000000);
}
STV.PrintVideoDetails();