using System.Collections.Generic;

namespace Qkmaxware.Namegen.Fantasy {

public class TieflingNameGenerator : BaseNameGenerator {

    private static StringGenerator generator = new StringGenerator(new Dictionary<string, List<string>>{
        {"pre", new List<string>{
            "ak", "ana", "bry", "cri", "dam", "eke", "la", "ka", "leu", "me", "mor", "pel", "ska", "the",
            "ea", "ler", "mak", "ori", "phe", "ri" 
        }},
        {"mid", new List<string>{
            "men", "no", "ma", "ko", "do", "ir", "em", "ra", "cu", "le", "da", "or", "th", "ai", "am", "er", "ak",
            "se", "ie", "ll", "ss", "nn", "la",
        }},
        {"end", new List<string>{
            "os", "on", "as", "is", "ch", "ai", "ta", "la", "a", "sa", "ia", "na"
        }}
    });

     private static List<string> Patterns = new List<string>{
        "@pre@mid@end",
        "@pre@mid@mid@end",
    };
    
    public override string Next() {
        return generator.Generate(Patterns);
    }
}

}