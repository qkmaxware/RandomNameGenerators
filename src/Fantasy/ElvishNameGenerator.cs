using System.Collections.Generic;

namespace Qkmaxware.Namegen.Fantasy {

public class ElvishNameGenerator : BaseNameGenerator {
    private static StringGenerator generator = new StringGenerator(new Dictionary<string, List<string>>{
        {"pre", new List<string> {
            "ad", "ae", "ar", "au", "be", "ca", "en", "er", "ga", "ha", "he", "hi", "im", "iv",
            "lau", "mi", "pae", "pe", "qu", "ria", "ro", "so", "th", "va", "xa", "k"
        }},
        {"mid", new List<string> {
            "a", "e", "i", "o", "u", "y", "ae", "ai", "au", "am", "ay", "ea", "ee",
            "ei", "eu", "ey", "ia", "ie", "oe", "oi", "oo", "ou", "ui", "nn", "ar",
            "da", "st", "er", "le", "st", "en", ""
        }},
        {"end", new List<string> {
            "ad", "th", "mil", "nis", "ro", "ian", "ic", "lis", "dan", "van", "rai", "ian",
            "mo", "al", "ios", "ian", "tis", "ias", "en", "ion", "don", "en", "ss", "vol",
            "tra", "ia", "le", "na", "te", "ir", "ra", "ne", "lo", "del", "ent", 
        }},
        {"name", new List<string>{
            "@pre@end",
            "@pre@mid@end",
            "@pre@mid@mid@end"
        }}
    });

    private static string Patterns = "@name";

    public override string Next() {
        return generator.Generate(Patterns) + " "  + generator.Generate(Patterns);
    }
}

}