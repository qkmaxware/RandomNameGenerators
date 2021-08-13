using System.Collections.Generic;

namespace Qkmaxware.Namegen.Fantasy {

public class DwarvishNameGenerator : BaseNameGenerator {
    private static StringGenerator generator = new StringGenerator(new Dictionary<string, List<string>>{
        {"p", new List<string> {
            "ad", "am", "ar", "al", "aud", "bar", "dag", "die", "dar", "de", "eb", "eld", "ein", "far", "falk", "fin", "fl",
            "gun", "gur", "gar", "har", "hl", "ka", "kri", "il", "mar", "mor", "or", "os", "ran", "ris", "rur", "rak", "thor", 
            "tor", "trau", "tra", "san", "ulf", "vis", "ve", "von", "vor",
        }},
        {"i", new List<string>{
            "a", "e", "i", "o", "u", "y", "ae", "ai", "au", "ay", "ea", "ee",
            "ei", "eu", "ey", "ia", "ie", "oe", "oi", "oo", "ou", "ui"
        }},
        {"s", new List<string>{
            "rik", "rich", "rn", "nor", "in", "ak", "lg", "rk", "kil", "grim", "ain", "bek", "rak", "gran",
            "kar", "red", "nl", "ra", "de", "ryd", "is", "sea", "asa", "it", "rin", "ik", "nt", "on", "gart",
            "gehr", "heim",
        }},
        {"fam", new List<string> {
            "Stone", "Iron", "Copper", "Steel", "Aluminum", "Gold", "Lead", "Nickel", "Cobalt", 
        }},
        {"des", new List<string>{
            "sword", "hammer", "pike", "axe", "anvil", "tong", "vise", "chisel",
            "fist", "beard", "hair", "heart", "soul",
            "crusher", "basher", "wrecker", "bender",
        }},
    });

    private static List<string> Patterns = new List<string>{
        "@p@s @fam@des",
        "@p@i@s @fam@des"
    };

    public override string Next() {
        return generator.Generate(Patterns);
    }
}

}