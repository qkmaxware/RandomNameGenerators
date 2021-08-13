using System.Collections.Generic;

namespace Qkmaxware.Namegen.Scifi {

public class AndorianNameGenerator : BaseNameGenerator {
    private static StringGenerator generator = new StringGenerator(new Dictionary<string, List<string>>{
        {"g", new List<string>{
            "Zh'", "Sh'", "Ch'", "Th'"
        }},
        {"s", new List<string>{ 
            "ach", "ack", "ad", "age", "ald", "ale", "an", "ang", "ar", "ard",
            "as", "ash", "at", "ath", "augh", "aw", "ban", "bel", "bur", "cer",
            "cha", "che", "dan", "dar", "del", "den", "dra", "dyn", "ech", "eld",
            "elm", "em", "en", "end", "eng", "enth", "er", "ess", "est", "et",
            "gar", "gha", "hat", "hin", "hon", "ia", "ight", "ild", "im", "ina",
            "ine", "ing", "ir", "is", "iss", "it", "kal", "kel", "kim", "kin",
            "ler", "lor", "lye", "mor", "mos", "nal", "ny", "nys", "old", "om",
            "on", "or", "orm", "os", "ough", "per", "pol", "qua", "que", "rad",
            "rak", "ran", "ray", "ril", "ris", "rod", "roth", "ryn", "sam",
            "say", "ser", "shy", "skel", "sul", "tai", "tan", "tas", "ther",
            "tia", "tin", "ton", "tor", "tur", "um", "und", "unt", "urn", "usk",
            "ust", "ver", "ves", "vor", "war", "wor", "yer"
        }},
        {"b", new List<string>{ 
            "b", "bl", "br", "c", "ch", "ck", "chr", "cl", "cr", "d", "dr", "f", "g",
            "gh", "h", "j", "k", "l", "ll", "m", "n", "nd", "nn", "nt", "p", "ph", "qu", "r", "rh", "rd", "rr",
            "rt", "s", "sch", "sh", "sl", "sm", "sn", "st", "str", "sw", "t", "th", "thr",
            "tr", "v", "w", "wh", "y", "z", "zh"
        }},
    });

    private static List<string> Patterns = new List<string>{
        "@b@s @g@s",
        "@b@s @g@b@s",
        "@b@s@s @g@s",
        "@b@s@s @g@b@s",
    };

    public override string Next() {
        return generator.Generate(Patterns);
    }
}

}