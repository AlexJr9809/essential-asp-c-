const string direct = "FileCollection";

const string filename = "Result.txt";

string ThisPath = Directory.GetCurrentDirectory();
string newDr;
long fzExcel = 0;
long fzWord = 0;
long fzPPT = 0;

int countExcel = 0;
int countWord = 0;
int countPPT = 0;



List<string> Contents = new List<string>(Directory.EnumerateDirectories(ThisPath));
newDr = Contents[1];
DirectoryInfo newPlace = new DirectoryInfo(newDr);

FileInfo[] ExcelFiles = newPlace.GetFiles("*.xlsx");
FileInfo[] WordFiles = newPlace.GetFiles("*.docx");
FileInfo[] PPTFiles = newPlace.GetFiles("*.pptx");

foreach(FileInfo i in ExcelFiles){
    fzExcel += i.Length;
    countExcel++;
}
foreach(FileInfo j in WordFiles){
    fzWord += j.Length;
    countWord++;
}
foreach(FileInfo k in PPTFiles){
    fzPPT += k.Length;
    countPPT++;
}

using (StreamWriter written = File.CreateText(filename)) { 
written.WriteLine("RESULTS");
written.WriteLine("FILE TYPE - TOTAL COUNT - TOTAL SIZE(KB)");
written.WriteLine($"  Word    -      {countWord}    -     {fzWord/1024}    ");
written.WriteLine($"  Excel    -      {countExcel}    -     {fzExcel/1024}    ");
written.WriteLine($"  PPT    -      {countPPT}    -     {fzPPT/1024}    ");
}

