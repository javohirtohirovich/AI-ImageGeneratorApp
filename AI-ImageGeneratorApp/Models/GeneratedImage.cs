using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_ImageGeneratorApp.Models;

public class GeneratedImage
{
    public string ImagePath {  get; set; }  
    public string MainKeyword {  get; set; }
    public IList<string> Keywords { get; set; }
}
