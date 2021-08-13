using System.Collections.Generic;

namespace Qkmaxware.Namegen.Fantasy {

public class HalflingNameGenerator : BaseNameGenerator {

    private static StringGenerator generator = new StringGenerator(new Dictionary<string, List<string>>{
        {"pre", new List<string>{
            "al", "an", "br", "ca", "cal", "co", "cor", "el", "err", "eu", "finn", "gar", "jill", 
            "kit", "lav", "lin", "ly", "lidd", "mer", "mer", "mi", "ne", "os", "pae", "per", "sera", 
            "shae", "re", "ro", "wel", "va", "ver",
        }},
        {"post", new List<string>{
            "ton", "er", "de", "don", "ich", "nan", "et", "al", "le", "ric", "lo", "born", "rin", "ed", 
            "coe", "by", "dry", "ee", "ra", "mia", "nia", "da", "la", "tia", "ina", "ena", "ni", "na",
        }},
        {"fam", new List<string>{
            "Brush", "Bottle", "Barrel", "Hill", "Tea", "Leaf", "Good", "Green", "Thorn",
        }},
        {"suffix", new List<string>{
            "gather", "Brush", "Bottle", "Barrel", "Hill", "Tea", "Leaf", "Good", "Green", "Thorn", "bough", "cobble",
            "gage", "bottle", "topple", "gallow"
        }}
    });
    
    public override string Next() {
        return generator.Generate("@pre@post @fam@suffix");
    }
}

}