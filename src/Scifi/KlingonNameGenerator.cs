using System.Collections.Generic;

namespace Qkmaxware.Namegen.Scifi {

public class KlingonNameGenerator : BaseNameGenerator {
    private static StringGenerator generator = new StringGenerator(new Dictionary<string, List<string>>{
        {"letter", new List<string>{
            "a", "b", "ch", "D", "e", "gh", "H", "I", "j", "l", "m", "n", "ng", "o", "p", "q", "Q", "r", "S", "t", "tlh", "u", "v", "w"
        }},
        {"word", new List<string>{
            "@letter",
            "@letter@letter",
            "@letter@letter@letter",
            "@letter@letter@letter@letter",
            "@letter@letter@letter@letter@letter"
        }},
        {"name", new List<string>{
            "@word",
            "@word'",
            "@word'@word",
            "@word'@word'",
        }}
    });

    private static List<string> Patterns = new List<string>{
        "@name"
    };

    public override string Next() {
        return generator.Generate(Patterns);
    }
}

}