using System.Collections.Generic;

namespace Qkmaxware.Namegen.Fantasy {

public class GnomishNameGenerator : BaseNameGenerator {

    private static StringGenerator generator = new StringGenerator(new Dictionary<string, List<string>>{
        {"pre", new List<string>{
            "al", "bod", "bro", "bur", "dim", "el", "fon", "fru", "ger", "gl", "jeb",
            "kel", "nam", "or", "roon", "see", "sin", "war", "wr", "zo", "bimp", "bre",
            "car", "don", "duv", "li", "loop", "lor", "mar", "nis", "ny", "od", "roy",
            "sha", "tan", "way", "zan",
        }},
        {"mid", new List<string> {
            "a", "e", "i", "o", "u", "y", "ae", "ai", "au", "am", "ay", "ea", "ee",
            "ei", "eu", "ey", "ia", "ie", "oe", "oi", "oo", "ou", "ui", "nn", "ar",
            "da", "st", "er", "le", "st", "en", ""
        }},
        {"post", new List<string>{
            "nottin", "ston", "nock", "gell", "ble", "don", "ky", "ug", "bo", "im", "do",
            "len", "foodle", "ryn", "dar", "dri", "na", "wock", "na", "mip", "lin", "ella",
            "bell", "wick", "mottin", "illa", "nab", "sa", "x", "a", "la", "wyn", "mil",
            "ren", "gel", "kor", "ick", "nig", "gel", "nor", "pen", "ers", "gem"
        }},
    });

    public override string Next() {
        return generator.Generate("@pre@post") + " " + generator.Generate("@pre@mid@post");
    }
}

}