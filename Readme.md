# C# Random Name Generators
Generate random names for characters in C#. Random generation is based on a DSL which employs repeated Regex replacements to fill variables from strings with random values for variable sets. This behaviour is defined in `Qkmaxware.Namegen.StringGenerator`. 

## DSL
The domain specific language for generating strings is as follows.
1. Variables are string identifiers that map to a list of possible values. Each value may in turn reference other variables. All variables are stored in a dictionary.
2. Within your string use `@varname` where varname is the name of the variable to replace that part of the string with. When the replacement occurs, a random value from the list of values that variable can be will be chosen.
3. Use `\<a>` to insert either the letter 'a' or the word 'an' depending on the next letter in the string
4. Use `(s)` at the end of a variable name IE `@varname(s)` to pluralize the result of the replacement. 

For instance, with the variables @animal, @action, and @location defined; and when used in the string below:
```
<a> @animal @action at @location
```
Could produce the following result
```
A dog eats at the mall
```

## Name Generation
Name generation utilizes a subset of features from the string generator DSL. By providing what sets of characters can be used and several base templates for how they can be arranged names can be generated. Some name generators include

### Fantasy Names (Qkmaxware.Namegen.Fantasy)
- Dragonborn
- Dwarvish
- Elvish
- Gnomish
- Halfling
- Tiefling
- Human

### Science Fiction Names (Qkmaxware.Namegen.Scifi)
- Andorian
- Klingon
- Human