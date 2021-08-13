using System.Collections.Generic;

namespace Qkmaxware.Namegen {

public interface INameGenerator {
    string Next();
    IEnumerable<string> Sequence();
}

public abstract class BaseNameGenerator : INameGenerator {
    public abstract string Next();

    public IEnumerable<string> Sequence() {
        while (true) {
            yield return Next();
        }
    }
}

}