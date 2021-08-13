using System.Collections.Generic;

namespace Qkmaxware.Namegen.Fantasy {

public class DragonbornNameGenerator : BaseNameGenerator {

    private static StringGenerator generator = new StringGenerator(new Dictionary<string, List<string>>{
        {"pre", new List<string>{
            "arj", "bal", "bha", "don", "ghe", "hes", "kri", "med", "meh", "pan", "par", "rho", 
            "sha", "she", "tar", "tor", "ak", "bi", "far", "har", "hav", "hje", "ka", "mis", "na",
            "per", "rai", "sor", "sur", "tha", "uad"
        }},
        {"mid", new List<string> {
            "a", "e", "i", "o", "u", "y", "ae", "ai", "au", "am", "ay", "ea", "ee",
            "ei", "eu", "ey", "ia", "ie", "oe", "oi", "oo", "ou", "ui", "nn", "ar",
            "da", "st", "er", "le", "st", "en"
        }},
        {"post", new List<string>{
            "han", "sar", "ash", "aar", "sh", "kan", "ash", "en", "arr", "rin", "gar", "dinn", "hun",
            "ra", "ri", "ar", "deh", "ann", "ilar", "ri", "va", "inn", "na", "jit"
        }},
        {"famPre", new List<string> {
            "Cleth", "Daar", "Del", "Dra", "Fen", "Kep", "Kerr", "Kim", "Lin", "Mya", "Nem", "Nor", 
            "Ophin", "Prex", "Shes", "Tur", "Ver", "Yar"
        }},
        {"famMid", new List<string> {
            "th", "den", "dri", "mir", "ach", "dan", "ken", "ca", "bra", "pesh", "mol", "hy", "lo", 
            "bat", "uul", "kas", "xak", "st", "ixi", "shtal", "jir", "xij", "dili", "sten", "del", 
            "lia", "nuro", "sath", "gie", "jeri", "mm",
        }},
        {"famLast", new List<string> {
            "lor", "rian", "rev", "ion", "don", "ik", "lon", "ul", "or", "an", "is", "us", "ir", "in",
            "th", "sh", "it", "in", "han", "sar", "ash", "aar", "sh", "kan", "ash", "en", "arr", "rin", "gar", 
            "dinn", "hun", "ra", "ri", "ar", "deh", "ann", "ilar", "ri", "va", "inn", "na", "jit"
        }},
        {"famName", new List<string>{
            "@famPre@famMid@famLast",
            "@famPre@famMid@famMid@famLast",
            "@famPre@famMid@famMid@famMid@famLast",
        }}
    });
    
    private static List<string> Patterns = new List<string>{
        "@pre@post @famName",
        "@pre@mid@post @famName"
    };

    public override string Next() {
        return generator.Generate(Patterns);
    }
}

}