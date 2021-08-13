using System.Collections.Generic;

namespace Qkmaxware.Namegen {

public partial class HumanNameGenerator : BaseNameGenerator {
    private static StringGenerator generator;
    static HumanNameGenerator() {
        generator = new StringGenerator(new Dictionary<string, List<string>>{
            {"firstname", firstnameList},
            {"surname", surnameList}
        });
    }

    private static string pattern = "@firstname @surname";

    public override string Next() {
        return generator.Generate(pattern);
    }
}

}