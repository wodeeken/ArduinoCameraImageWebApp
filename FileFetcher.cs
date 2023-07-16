using System.IO;
public class FileFetcher{
    private string ImageDirectory; 
    public FileFetcher(string ImageDirectory){
        this.ImageDirectory = ImageDirectory;
    }
    public List< DayImages> GetImages(DateTime beginTime, DateTime endTime){
        List<DayImages> returnList = new List<DayImages>();
        if(beginTime.Date <= endTime.Date){
            DateTime currentTime = beginTime.Date;
            while(currentTime <= endTime.Date){
            
                // Each subdirectory represents a day. Subdirectory name is of the form "MM_DD_YYYY"
                // Form search pattern "MM_DD_YYYY"
                var searchPattern = currentTime.Month.ToString("00") + "_" + currentTime.Day.ToString("00") + "_" + 
                        currentTime.Year.ToString("0000");
                var subDirPaths = Directory.GetDirectories(ImageDirectory,searchPattern);
                if(subDirPaths.Length == 1){
                    // Get all files. 
                    var files = Directory.GetFiles(subDirPaths.First());
                    List<Tuple<DateTime,string>> hour0_Images = null;
                        List<Tuple<DateTime,string>> hour1_Images = null;
                        List<Tuple<DateTime,string>> hour2_Images = null;
                        List<Tuple<DateTime,string>> hour3_Images = null;
                        List<Tuple<DateTime,string>> hour4_Images = null;
                        List<Tuple<DateTime,string>> hour5_Images = null;
                        List<Tuple<DateTime,string>> hour6_Images = null;
                        List<Tuple<DateTime,string>> hour7_Images = null;
                        List<Tuple<DateTime,string>> hour8_Images = null;
                        List<Tuple<DateTime,string>> hour9_Images= null; 
                        List<Tuple<DateTime,string>> hour10_Images= null ;
                        List<Tuple<DateTime,string>> hour11_Images= null ;
                        List<Tuple<DateTime,string>> hour12_Images= null;
                        List<Tuple<DateTime,string>> hour13_Images= null;
                        List<Tuple<DateTime,string>> hour14_Images = null;
                        List<Tuple<DateTime,string>> hour15_Images = null;
                        List<Tuple<DateTime,string>> hour16_Images = null;
                        List<Tuple<DateTime,string>> hour17_Images = null;
                        List<Tuple<DateTime,string>> hour18_Images  = null;
                        List<Tuple<DateTime,string>> hour19_Images  = null;
                        List<Tuple<DateTime,string>> hour20_Images= null;
                        List<Tuple<DateTime,string>> hour21_Images = null;
                        List<Tuple<DateTime,string>> hour22_Images = null;
                        List<Tuple<DateTime,string>> hour23_Images= null;
                    try{
                         hour0_Images = DatetimeHelper(currentTime,files.Where(x => x.Split("/")[x.Split("/").Count() - 1].Substring(0,2) == "00").ToList()) ;
                         hour1_Images = DatetimeHelper(currentTime,files.Where(x => x.Split("/")[x.Split("/").Count() - 1].Substring(0,2) == "01").ToList()) ;
                         hour2_Images = DatetimeHelper(currentTime,files.Where(x => x.Split("/")[x.Split("/").Count() - 1].Substring(0,2) == "02").ToList()) ;
                         hour3_Images = DatetimeHelper(currentTime,files.Where(x => x.Split("/")[x.Split("/").Count() - 1].Substring(0,2) == "03").ToList()) ;
                         hour4_Images = DatetimeHelper(currentTime,files.Where(x => x.Split("/")[x.Split("/").Count() - 1].Substring(0,2) == "04").ToList()) ;
                         hour5_Images = DatetimeHelper(currentTime,files.Where(x => x.Split("/")[x.Split("/").Count() - 1].Substring(0,2) == "05").ToList()) ;
                         hour6_Images = DatetimeHelper(currentTime,files.Where(x => x.Split("/")[x.Split("/").Count() - 1].Substring(0,2) == "06").ToList()) ;
                         hour7_Images = DatetimeHelper(currentTime,files.Where(x => x.Split("/")[x.Split("/").Count() - 1].Substring(0,2) == "07").ToList()) ;
                         hour8_Images = DatetimeHelper(currentTime,files.Where(x => x.Split("/")[x.Split("/").Count() - 1].Substring(0,2) == "08").ToList()) ;
                         hour9_Images = DatetimeHelper(currentTime,files.Where(x => x.Split("/")[x.Split("/").Count() - 1].Substring(0,2) == "09").ToList()) ;
                         hour10_Images = DatetimeHelper(currentTime,files.Where(x => x.Split("/")[x.Split("/").Count() - 1].Substring(0,2) == "10").ToList()) ;
                         hour11_Images = DatetimeHelper(currentTime,files.Where(x => x.Split("/")[x.Split("/").Count() - 1].Substring(0,2) == "11").ToList()) ;
                         hour12_Images = DatetimeHelper(currentTime,files.Where(x => x.Split("/")[x.Split("/").Count() - 1].Substring(0,2) == "12").ToList()) ;
                         hour13_Images = DatetimeHelper(currentTime,files.Where(x => x.Split("/")[x.Split("/").Count() - 1].Substring(0,2) == "13").ToList()) ;
                         hour14_Images = DatetimeHelper(currentTime,files.Where(x => x.Split("/")[x.Split("/").Count() - 1].Substring(0,2) == "14").ToList()) ;
                         hour15_Images = DatetimeHelper(currentTime,files.Where(x => x.Split("/")[x.Split("/").Count() - 1].Substring(0,2) == "15").ToList()) ;
                         hour16_Images = DatetimeHelper(currentTime,files.Where(x => x.Split("/")[x.Split("/").Count() - 1].Substring(0,2) == "16").ToList()) ;
                         hour17_Images = DatetimeHelper(currentTime,files.Where(x => x.Split("/")[x.Split("/").Count() - 1].Substring(0,2) == "17").ToList()) ;
                         hour18_Images = DatetimeHelper(currentTime,files.Where(x => x.Split("/")[x.Split("/").Count() - 1].Substring(0,2) == "18").ToList()) ;
                         hour19_Images = DatetimeHelper(currentTime,files.Where(x => x.Split("/")[x.Split("/").Count() - 1].Substring(0,2) == "19").ToList()) ;
                         hour20_Images = DatetimeHelper(currentTime,files.Where(x => x.Split("/")[x.Split("/").Count() - 1].Substring(0,2) == "20").ToList()) ;
                         hour21_Images = DatetimeHelper(currentTime,files.Where(x => x.Split("/")[x.Split("/").Count() - 1].Substring(0,2) == "21").ToList()) ;
                         hour22_Images = DatetimeHelper(currentTime,files.Where(x => x.Split("/")[x.Split("/").Count() - 1].Substring(0,2) == "22").ToList()) ;
                         hour23_Images = DatetimeHelper(currentTime,files.Where(x => x.Split("/")[x.Split("/").Count() - 1].Substring(0,2) == "23").ToList());
                    }catch(Exception e){
                        Console.WriteLine("FileFetcher.GetImages - for date " + currentTime.ToString() + "an image file with malformed name exists.");
                    }
                    returnList.Add( new DayImages( currentTime.Date,  hour0_Images,
                                                                                    hour1_Images,
                                                                                    hour2_Images,
                                                                                    hour3_Images,
                                                                                    hour4_Images,
                                                                                    hour5_Images,
                                                                                    hour6_Images,
                                                                                    hour7_Images,
                                                                                    hour8_Images,
                                                                                    hour9_Images,
                                                                                    hour10_Images,
                                                                                    hour11_Images,
                                                                                    hour12_Images,
                                                                                    hour13_Images,  
                                                                                    hour14_Images,
                                                                                    hour15_Images,
                                                                                    hour16_Images,
                                                                                    hour17_Images,
                                                                                    hour18_Images,
                                                                                    hour19_Images,
                                                                                    hour20_Images,
                                                                                    hour21_Images,
                                                                                    hour22_Images,
                                                                                    hour23_Images));
                }else if(subDirPaths.Length > 1)
                    Console.WriteLine("FileFetcher.GetImages - Multiple folders for date" + currentTime.ToString());
                currentTime = currentTime.AddDays(1);
            }
        }
        return returnList;
    }
    // Private helper parses datetime from string name.
    private List<Tuple<DateTime, string>> DatetimeHelper(DateTime currentDate, List<string> files){
        Console.WriteLine("Entered DatetimeHelper with CurrentDate: " + currentDate.ToString() + ", and a list of files of length: " + files.Count() );
        List<Tuple<DateTime,string>> returnList = new List<Tuple<DateTime, string>>();
        foreach(string path in files){
            Console.WriteLine("Current file: " + path);
            DateTime parsedDate;
            var fileName = path.Split("/")[path.Split("/").Count() - 1];
            var hours = Int32.Parse(fileName.Split("_")[0]);
            var mins = Int32.Parse(fileName.Split("_")[1]);
            var secs = Int32.Parse(fileName.Split("_")[2].Split(".")[0]);
            parsedDate = currentDate.Date.AddHours(hours).AddMinutes(mins).AddSeconds(secs);
            // Must truncate path. 
            returnList.Add(new Tuple<DateTime, string>(parsedDate, "/Images/" + currentDate.ToString("MM_dd_yyyy") + "/" + fileName ));
        }
        return returnList.OrderBy(x => x.Item1).ToList();
    }
}