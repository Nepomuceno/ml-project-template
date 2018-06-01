namespace ml.generator.template
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Template
    {
        /// <summary>
        /// The name in the source tree to replace with the name the user specifies
        /// </summary>
        [JsonProperty("sourceName", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceName { get; set; }

        /// <summary>
        /// A shorthand name or a list of names for selecting the template (applies to environments
        /// where the template name is specified by the user - not selected via a GUI). The first
        /// entry is the preferred short name.
        /// </summary>
        [JsonProperty("shortName")]
        public ShortName ShortName { get; set; }

        [JsonProperty("precedence", NullValueHandling = NullValueHandling.Ignore)]
        public Precedence? Precedence { get; set; }

        /// <summary>
        /// A list of guids which appear in the template source and should be replaced in the
        /// template output. For each guid listed, a replacement guid is generated, and replaces all
        /// occurrences of the source guid in the output.
        /// </summary>
        [JsonProperty("guids", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Guids { get; set; }

        /// <summary>
        /// The author of the template
        /// </summary>
        [JsonProperty("author")]
        public string Author { get; set; }

        /// <summary>
        /// The name for the template that users should see
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("defaultName", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultName { get; set; }

        /// <summary>
        /// Zero or more characteristics of the template that a user might search for it by
        /// </summary>
        [JsonProperty("classifications")]
        public string[] Classifications { get; set; }

        [JsonProperty("generatorVersions", NullValueHandling = NullValueHandling.Ignore)]
        public string GeneratorVersions { get; set; }

        /// <summary>
        /// A list of important output paths created during template generation. These paths need to
        /// be added to the newly created project at the end of template creation.
        /// </summary>
        [JsonProperty("primaryOutputs", NullValueHandling = NullValueHandling.Ignore)]
        public PrimaryOutput[] PrimaryOutputs { get; set; }

        [JsonProperty("preferNameDirectory", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PreferNameDirectory { get; set; }

        /// <summary>
        /// The set of mappings in the template content to user directories
        /// </summary>
        [JsonProperty("sources", NullValueHandling = NullValueHandling.Ignore)]
        public Source[] Sources { get; set; }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public Tags Tags { get; set; }

        /// <summary>
        /// A filename that will be completely ignored except to indicate that its containing
        /// directory should be copied. This allows creation of an empty directory in the created
        /// template, by having a corresponding source directory containing just the placeholder
        /// file. Completely empty directories are ignored.
        /// </summary>
        [JsonProperty("placeholderFilename", NullValueHandling = NullValueHandling.Ignore)]
        public string PlaceholderFilename { get; set; }

        /// <summary>
        /// The symbols section defines variables and their values, the values may be the defined in
        /// terms of other symbols. When a defined symbol name is encountered anywhere in the
        /// template definition, it is replaced by the value defined in this configuration. The
        /// symbols configuration is a collection of key-value pairs. The keys are the symbol names,
        /// and the value contains key-value-pair configuration information on how to assign the
        /// symbol a value.
        /// </summary>
        [JsonProperty("symbols", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Symbol> Symbols { get; set; }

        [JsonProperty("thirdPartyNotices", NullValueHandling = NullValueHandling.Ignore)]
        public string ThirdPartyNotices { get; set; }

        /// <summary>
        /// Defines an ordered list of actions to perform after template generation. The post action
        /// information is provided to the creation broker, to act on as appropriate.
        /// </summary>
        [JsonProperty("postActions", NullValueHandling = NullValueHandling.Ignore)]
        public PostAction[] PostActions { get; set; }

        /// <summary>
        /// The ID of the group this template belongs to. When combined with the "tags" section, this
        /// allows multiple templates to be displayed as one, with the the decision for which one to
        /// use being presented as a choice in each one of the pivot categories (keys).
        /// </summary>
        [JsonProperty("groupIdentity", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupIdentity { get; set; }

        /// <summary>
        /// A unique name for this template
        /// </summary>
        [JsonProperty("identity")]
        public string Identity { get; set; }
    }

    /// <summary>
    /// Defines an ordered list of actions to perform after template generation. The post action
    /// information is provided to the creation broker, to act on as appropriate.
    /// </summary>
    public partial class PostAction
    {
        /// <summary>
        /// A guid uniquely defining the action. The value must correspond to a post-action known by
        /// the broker.
        /// </summary>
        [JsonProperty("actionId")]
        public string ActionId { get; set; }

        /// <summary>
        /// A list of key-value pairs to use when performing the action. The specific parameters
        /// required / allowed are defined by the action itself.
        /// </summary>
        [JsonProperty("args", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Args { get; set; }

        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public string Condition { get; set; }

        /// <summary>
        /// Additional configuration for the associated post action. The structure & content will
        /// vary based on the post action.
        /// </summary>
        [JsonProperty("configFile", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigFile { get; set; }

        /// <summary>
        /// If this action fails, the value of continueOnError indicates whether to attempt the next
        /// action, or stop processing the post actions. Should be set to true when subsequent
        /// actions rely on the success of the current action.
        /// </summary>
        [JsonProperty("continueOnError", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ContinueOnError { get; set; }

        /// <summary>
        /// A human-readable description of the action.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// An ordered list of possible instructions to display if the action cannot be performed.
        /// Each element in the list must contain a key named "text", whose value contains the
        /// instructions. Each element may also optionally provide a key named "condition" - a
        /// Boolean evaluate-able string. The first instruction whose condition is false or blank
        /// will be considered valid, all others are ignored.
        /// </summary>
        [JsonProperty("manualInstructions")]
        public ManualInstruction[] ManualInstructions { get; set; }
    }

    /// <summary>
    /// An ordered list of possible instructions to display if the action cannot be performed.
    /// Each element in the list must contain a key named "text", whose value contains the
    /// instructions. Each element may also optionally provide a key named "condition" - a
    /// Boolean evaluate-able string. The first instruction whose condition is false or blank
    /// will be considered valid, all others are ignored.
    /// </summary>
    public partial class ManualInstruction
    {
        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public string Condition { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    /// <summary>
    /// A list of important output paths created during template generation. These paths need to
    /// be added to the newly created project at the end of template creation.
    /// </summary>
    public partial class PrimaryOutput
    {
        /// <summary>
        /// One instance of a primary output path
        /// </summary>
        [JsonProperty("path")]
        public string Path { get; set; }

        /// <summary>
        /// If the condition evaluates to true, the corresponding path will be included in the output
        /// list. If false, the path is ignored
        /// </summary>
        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public string Condition { get; set; }
    }

    /// <summary>
    /// The set of mappings in the template content to user directories
    ///
    /// A list of additional source information which gets added to the top-level source
    /// information, based on evaluation the corresponding source.modifiers.condition.
    /// </summary>
    public partial class Source
    {
        /// <summary>
        /// A list of additional source information which gets added to the top-level source
        /// information, based on evaluation the corresponding source.modifiers.condition.
        /// </summary>
        [JsonProperty("modifiers", NullValueHandling = NullValueHandling.Ignore)]
        public Modifier[] Modifiers { get; set; }

        /// <summary>
        /// The path in the template content (relative to the directory containing the
        /// .template.config folder) that should be processed
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceSource { get; set; }

        /// <summary>
        /// The path (relative to the directory the user has specified) that content should be
        /// written to
        /// </summary>
        [JsonProperty("target", NullValueHandling = NullValueHandling.Ignore)]
        public string Target { get; set; }

        /// <summary>
        /// Boolean-evaluable condition to indicate if the sources configuration should be included
        /// or ignored. If the condition evaluates to true or is not provided, the sources config
        /// will be used for creating the template. If it evaluates to false, the sources config will
        /// be ignored.
        /// </summary>
        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public string Condition { get; set; }

        /// <summary>
        /// The set of globbing patterns indicating the content that was included by sources.include
        /// that should not be processed
        /// </summary>
        [JsonProperty("exclude", NullValueHandling = NullValueHandling.Ignore)]
        public Ice? Exclude { get; set; }

        /// <summary>
        /// The set of globbing patterns indicating the content to process in the path referred to by
        /// sources.source
        /// </summary>
        [JsonProperty("include", NullValueHandling = NullValueHandling.Ignore)]
        public Ice? Include { get; set; }

        /// <summary>
        /// The set of globbing patterns indicating the content that was included by sources.include,
        /// that hasn't been excluded by sources.exclude that should be placed in the user's
        /// directory without modification
        /// </summary>
        [JsonProperty("copyOnly", NullValueHandling = NullValueHandling.Ignore)]
        public Ice? CopyOnly { get; set; }

        /// <summary>
        /// The set of explicit renames to perform. Each key is a path to a file in the source, each
        /// value is a path to the target location - only the values will be evaluated with the
        /// information the user supplies
        /// </summary>
        [JsonProperty("rename", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Rename { get; set; }
    }

    /// <summary>
    /// A list of additional source information which gets added to the top-level source
    /// information, based on evaluation the corresponding source.modifiers.condition.
    /// </summary>
    public partial class Modifier
    {
        [JsonProperty("modifiers", NullValueHandling = NullValueHandling.Ignore)]
        public Modifier[] Modifiers { get; set; }

        /// <summary>
        /// Boolean-evaluable condition to indicate if the sources configuration should be included
        /// or ignored. If the condition evaluates to true or is not provided, the sources config
        /// will be used for creating the template. If it evaluates to false, the sources config will
        /// be ignored.
        /// </summary>
        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public string Condition { get; set; }

        /// <summary>
        /// The set of globbing patterns indicating the content that was included by sources.include
        /// that should not be processed
        /// </summary>
        [JsonProperty("exclude", NullValueHandling = NullValueHandling.Ignore)]
        public Ice? Exclude { get; set; }

        /// <summary>
        /// The set of globbing patterns indicating the content to process in the path referred to by
        /// sources.source
        /// </summary>
        [JsonProperty("include", NullValueHandling = NullValueHandling.Ignore)]
        public Ice? Include { get; set; }

        /// <summary>
        /// The set of globbing patterns indicating the content that was included by sources.include,
        /// that hasn't been excluded by sources.exclude that should be placed in the user's
        /// directory without modification
        /// </summary>
        [JsonProperty("copyOnly", NullValueHandling = NullValueHandling.Ignore)]
        public Ice? CopyOnly { get; set; }

        /// <summary>
        /// The set of explicit renames to perform. Each key is a path to a file in the source, each
        /// value is a path to the target location - only the values will be evaluated with the
        /// information the user supplies
        /// </summary>
        [JsonProperty("rename", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Rename { get; set; }
    }

    public partial class Symbol
    {
        /// <summary>
        /// Defines the high level configuration of symbol
        /// </summary>
        [JsonProperty("type")]
        public SymbolType Type { get; set; }

        [JsonProperty("generator", NullValueHandling = NullValueHandling.Ignore)]
        public Generator? Generator { get; set; }

        [JsonProperty("parameters")]
        public ParametersUnion? Parameters { get; set; }

        /// <summary>
        /// Indicates limitations on the valid values a symbol may be assigned. At this point, the
        /// only valid datatype is "choice", which also requires providing symbols.choices
        /// configuration for the symbol.
        /// </summary>
        [JsonProperty("datatype")]
        public object Datatype { get; set; }

        /// <summary>
        /// An array listing the valid choices for a symbol whose datatype = choice. If not provided,
        /// there are no valid choices for the symbol, so it can never be assigned a value.
        /// </summary>
        [JsonProperty("choices", NullValueHandling = NullValueHandling.Ignore)]
        public List<ChoiceElement> Choices { get; set; }

        [JsonProperty("replaces", NullValueHandling = NullValueHandling.Ignore)]
        public string Replaces { get; set; }

        /// <summary>
        /// The value assigned to the symbol if no value for it is provided by the user or host.
        /// </summary>
        [JsonProperty("defaultValue", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// The description of the parameter
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("onlyIf")]
        public OnlyIfUnion? OnlyIf { get; set; }

        /// <summary>
        /// An evaluate-able condition whose result defines the value of the symbol.
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }
    }

    public partial class ChoiceClass
    {
        [JsonProperty("choice")]
        public string Choice { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }
    }

    public partial class OnlyIfClass
    {
        /// <summary>
        /// The replacement string occurs after this value
        /// </summary>
        [JsonProperty("after", NullValueHandling = NullValueHandling.Ignore)]
        public string After { get; set; }

        /// <summary>
        /// The replacement string occurs before this value
        /// </summary>
        [JsonProperty("before", NullValueHandling = NullValueHandling.Ignore)]
        public string Before { get; set; }
    }

    public partial class ParametersClass
    {
        /// <summary>
        /// The value to be assigned to the symbol
        ///
        /// The Boolean predicate whose evaluation result becomes the symbol value
        ///
        /// Must be the string literal "new".
        ///
        /// The format string to use when converting the date-time to a string representation.
        ///
        /// Must be the string literal "new"
        ///
        /// Must be the string literal "replace"
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// A string indicating the predicate evaluator to evaluate the action against.
        /// </summary>
        [JsonProperty("evaluator", NullValueHandling = NullValueHandling.Ignore)]
        public string Evaluator { get; set; }

        /// <summary>
        /// When a string representation of the guid is needed, this is used as the format string in
        /// Guid.ToString().
        /// </summary>
        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public string Format { get; set; }

        /// <summary>
        /// If true, use UTC time. If false, use local time.
        /// </summary>
        [JsonProperty("utc", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Utc { get; set; }

        /// <summary>
        /// An integer value indicating the low-end of the range to generate the random number in.
        /// </summary>
        [JsonProperty("low", NullValueHandling = NullValueHandling.Ignore)]
        public long? Low { get; set; }

        /// <summary>
        /// An integer value indicating the high-end of the range to generate the random number in.
        /// If not explicitly provided, defaults to int.MaxValue.
        /// </summary>
        [JsonProperty("high", NullValueHandling = NullValueHandling.Ignore)]
        public long? High { get; set; }

        /// <summary>
        /// The name of a different parameter in the template configuration. A copy of its value will
        /// be used by this generator's regex to generate the value for this parameter. The value of
        /// the source parameter is not modified
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        /// <summary>
        /// An ordered list of key-value pairs indicating the regex replacement actions. Each element
        /// of the list must contain exactly the keys 'regex' and 'replacement' - along with their
        /// values. These replacements will be applied to the result of the previous replacement
        /// (except the first, which acts on the original value from the source).
        /// </summary>
        [JsonProperty("steps", NullValueHandling = NullValueHandling.Ignore)]
        public StepElement[] Steps { get; set; }
    }

    public partial class StepClass
    {
        [JsonProperty("regex")]
        public string Regex { get; set; }

        [JsonProperty("replacement")]
        public string Replacement { get; set; }
    }

    public partial class Tags
    {
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
    }

    /// <summary>
    /// A shorthand name or a list of names for selecting the template (applies to environments
    /// where the template name is specified by the user - not selected via a GUI). The first
    /// entry is the preferred short name.
    ///
    /// An ordered list of key-value pairs indicating the regex replacement actions. Each element
    /// of the list must contain exactly the keys 'regex' and 'replacement' - along with their
    /// values. These replacements will be applied to the result of the previous replacement
    /// (except the first, which acts on the original value from the source).
    ///
    /// An array listing the valid choices for a symbol whose datatype = choice. If not provided,
    /// there are no valid choices for the symbol, so it can never be assigned a value.
    ///
    /// Indicates limitations on the valid values a symbol may be assigned. At this point, the
    /// only valid datatype is "choice", which also requires providing symbols.choices
    /// configuration for the symbol.
    /// </summary>
    public enum Generator { Casing, Coalesce, Constant, Evaluate, Guid, Now, Port, Random, Regex, Switch };

    /// <summary>
    /// Defines the high level configuration of symbol
    ///
    /// A shorthand name or a list of names for selecting the template (applies to environments
    /// where the template name is specified by the user - not selected via a GUI). The first
    /// entry is the preferred short name.
    ///
    /// An ordered list of key-value pairs indicating the regex replacement actions. Each element
    /// of the list must contain exactly the keys 'regex' and 'replacement' - along with their
    /// values. These replacements will be applied to the result of the previous replacement
    /// (except the first, which acts on the original value from the source).
    ///
    /// An array listing the valid choices for a symbol whose datatype = choice. If not provided,
    /// there are no valid choices for the symbol, so it can never be assigned a value.
    ///
    /// Indicates limitations on the valid values a symbol may be assigned. At this point, the
    /// only valid datatype is "choice", which also requires providing symbols.choices
    /// configuration for the symbol.
    /// </summary>
    public enum SymbolType { Bind, Computed, Generated, Parameter };

    public partial struct Precedence
    {
        public long? Integer;
        public string String;
    }

    /// <summary>
    /// A shorthand name or a list of names for selecting the template (applies to environments
    /// where the template name is specified by the user - not selected via a GUI). The first
    /// entry is the preferred short name.
    /// </summary>
    public partial struct ShortName
    {
        public object[] AnythingArray;
        public string String;
    }

    /// <summary>
    /// The set of globbing patterns indicating the content that was included by sources.include,
    /// that hasn't been excluded by sources.exclude that should be placed in the user's
    /// directory without modification
    ///
    /// The set of globbing patterns indicating the content that was included by sources.include
    /// that should not be processed
    ///
    /// The set of globbing patterns indicating the content to process in the path referred to by
    /// sources.source
    ///
    /// A shorthand name or a list of names for selecting the template (applies to environments
    /// where the template name is specified by the user - not selected via a GUI). The first
    /// entry is the preferred short name.
    ///
    /// An ordered list of key-value pairs indicating the regex replacement actions. Each element
    /// of the list must contain exactly the keys 'regex' and 'replacement' - along with their
    /// values. These replacements will be applied to the result of the previous replacement
    /// (except the first, which acts on the original value from the source).
    ///
    /// An array listing the valid choices for a symbol whose datatype = choice. If not provided,
    /// there are no valid choices for the symbol, so it can never be assigned a value.
    ///
    /// Indicates limitations on the valid values a symbol may be assigned. At this point, the
    /// only valid datatype is "choice", which also requires providing symbols.choices
    /// configuration for the symbol.
    /// </summary>
    public partial struct Ice
    {
        public string String;
        public string[] StringArray;
    }

    /// <summary>
    /// An array listing the valid choices for a symbol whose datatype = choice. If not provided,
    /// there are no valid choices for the symbol, so it can never be assigned a value.
    /// </summary>
    public partial struct ChoiceElement
    {
        public object[] AnythingArray;
        public bool? Bool;
        public ChoiceClass ChoiceClass;
        public double? Double;
        public long? Integer;
        public string String;
    }

    /// <summary>
    /// A shorthand name or a list of names for selecting the template (applies to environments
    /// where the template name is specified by the user - not selected via a GUI). The first
    /// entry is the preferred short name.
    ///
    /// An ordered list of key-value pairs indicating the regex replacement actions. Each element
    /// of the list must contain exactly the keys 'regex' and 'replacement' - along with their
    /// values. These replacements will be applied to the result of the previous replacement
    /// (except the first, which acts on the original value from the source).
    ///
    /// An array listing the valid choices for a symbol whose datatype = choice. If not provided,
    /// there are no valid choices for the symbol, so it can never be assigned a value.
    ///
    /// Indicates limitations on the valid values a symbol may be assigned. At this point, the
    /// only valid datatype is "choice", which also requires providing symbols.choices
    /// configuration for the symbol.
    /// </summary>
    public partial struct OnlyIfUnion
    {
        public object[] AnythingArray;
        public bool? Bool;
        public double? Double;
        public long? Integer;
        public OnlyIfClass OnlyIfClass;
        public string String;
    }

    /// <summary>
    /// A shorthand name or a list of names for selecting the template (applies to environments
    /// where the template name is specified by the user - not selected via a GUI). The first
    /// entry is the preferred short name.
    ///
    /// An ordered list of key-value pairs indicating the regex replacement actions. Each element
    /// of the list must contain exactly the keys 'regex' and 'replacement' - along with their
    /// values. These replacements will be applied to the result of the previous replacement
    /// (except the first, which acts on the original value from the source).
    ///
    /// An array listing the valid choices for a symbol whose datatype = choice. If not provided,
    /// there are no valid choices for the symbol, so it can never be assigned a value.
    ///
    /// Indicates limitations on the valid values a symbol may be assigned. At this point, the
    /// only valid datatype is "choice", which also requires providing symbols.choices
    /// configuration for the symbol.
    /// </summary>
    public partial struct ParametersUnion
    {
        public object[] AnythingArray;
        public bool? Bool;
        public double? Double;
        public long? Integer;
        public ParametersClass ParametersClass;
        public string String;
    }

    /// <summary>
    /// An ordered list of key-value pairs indicating the regex replacement actions. Each element
    /// of the list must contain exactly the keys 'regex' and 'replacement' - along with their
    /// values. These replacements will be applied to the result of the previous replacement
    /// (except the first, which acts on the original value from the source).
    /// </summary>
    public partial struct StepElement
    {
        public object[] AnythingArray;
        public bool? Bool;
        public double? Double;
        public long? Integer;
        public StepClass StepClass;
        public string String;
    }

    public partial class Template
    {
        public static Template FromJson(string json) => JsonConvert.DeserializeObject<Template>(json, Converter.Settings);
    }

    static class GeneratorExtensions
    {
        public static Generator? ValueForString(string str)
        {
            switch (str)
            {
                case "casing": return Generator.Casing;
                case "coalesce": return Generator.Coalesce;
                case "constant": return Generator.Constant;
                case "evaluate": return Generator.Evaluate;
                case "guid": return Generator.Guid;
                case "now": return Generator.Now;
                case "port": return Generator.Port;
                case "random": return Generator.Random;
                case "regex": return Generator.Regex;
                case "switch": return Generator.Switch;
                default: return null;
            }
        }

        public static Generator ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this Generator value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case Generator.Casing: serializer.Serialize(writer, "casing"); break;
                case Generator.Coalesce: serializer.Serialize(writer, "coalesce"); break;
                case Generator.Constant: serializer.Serialize(writer, "constant"); break;
                case Generator.Evaluate: serializer.Serialize(writer, "evaluate"); break;
                case Generator.Guid: serializer.Serialize(writer, "guid"); break;
                case Generator.Now: serializer.Serialize(writer, "now"); break;
                case Generator.Port: serializer.Serialize(writer, "port"); break;
                case Generator.Random: serializer.Serialize(writer, "random"); break;
                case Generator.Regex: serializer.Serialize(writer, "regex"); break;
                case Generator.Switch: serializer.Serialize(writer, "switch"); break;
            }
        }
    }

    static class SymbolTypeExtensions
    {
        public static SymbolType? ValueForString(string str)
        {
            switch (str)
            {
                case "bind": return SymbolType.Bind;
                case "computed": return SymbolType.Computed;
                case "generated": return SymbolType.Generated;
                case "parameter": return SymbolType.Parameter;
                default: return null;
            }
        }

        public static SymbolType ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this SymbolType value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case SymbolType.Bind: serializer.Serialize(writer, "bind"); break;
                case SymbolType.Computed: serializer.Serialize(writer, "computed"); break;
                case SymbolType.Generated: serializer.Serialize(writer, "generated"); break;
                case SymbolType.Parameter: serializer.Serialize(writer, "parameter"); break;
            }
        }
    }

    public partial struct Precedence
    {
        public Precedence(JsonReader reader, JsonSerializer serializer)
        {
            Integer = null;
            String = null;

            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                    Integer = serializer.Deserialize<long>(reader);
                    return;
                case JsonToken.String:
                case JsonToken.Date:
                    String = serializer.Deserialize<string>(reader);
                    return;
            }
            throw new Exception("Cannot convert Precedence");
        }

        public void WriteJson(JsonWriter writer, JsonSerializer serializer)
        {
            if (Integer != null)
            {
                serializer.Serialize(writer, Integer);
                return;
            }
            if (String != null)
            {
                serializer.Serialize(writer, String);
                return;
            }
            throw new Exception("Union must not be null");
        }
    }

    public partial struct ShortName
    {
        public ShortName(JsonReader reader, JsonSerializer serializer)
        {
            AnythingArray = null;
            String = null;

            switch (reader.TokenType)
            {
                case JsonToken.StartArray:
                    AnythingArray = serializer.Deserialize<object[]>(reader);
                    return;
                case JsonToken.String:
                case JsonToken.Date:
                    String = serializer.Deserialize<string>(reader);
                    return;
            }
            throw new Exception("Cannot convert ShortName");
        }

        public void WriteJson(JsonWriter writer, JsonSerializer serializer)
        {
            if (AnythingArray != null)
            {
                serializer.Serialize(writer, AnythingArray);
                return;
            }
            if (String != null)
            {
                serializer.Serialize(writer, String);
                return;
            }
            throw new Exception("Union must not be null");
        }
    }

    public partial struct Ice
    {
        public Ice(JsonReader reader, JsonSerializer serializer)
        {
            String = null;
            StringArray = null;

            switch (reader.TokenType)
            {
                case JsonToken.StartArray:
                    StringArray = serializer.Deserialize<string[]>(reader);
                    return;
                case JsonToken.String:
                case JsonToken.Date:
                    String = serializer.Deserialize<string>(reader);
                    return;
            }
            throw new Exception("Cannot convert Ice");
        }

        public void WriteJson(JsonWriter writer, JsonSerializer serializer)
        {
            if (String != null)
            {
                serializer.Serialize(writer, String);
                return;
            }
            if (StringArray != null)
            {
                serializer.Serialize(writer, StringArray);
                return;
            }
            throw new Exception("Union must not be null");
        }
    }

    public partial struct ChoiceElement
    {
        public ChoiceElement(JsonReader reader, JsonSerializer serializer)
        {
            AnythingArray = null;
            Bool = null;
            ChoiceClass = null;
            Double = null;
            Integer = null;
            String = null;

            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return;
                case JsonToken.Integer:
                    Integer = serializer.Deserialize<long>(reader);
                    return;
                case JsonToken.Float:
                    Double = serializer.Deserialize<double>(reader);
                    return;
                case JsonToken.Boolean:
                    Bool = serializer.Deserialize<bool>(reader);
                    return;
                case JsonToken.StartArray:
                    AnythingArray = serializer.Deserialize<object[]>(reader);
                    return;
                case JsonToken.StartObject:
                    ChoiceClass = serializer.Deserialize<ChoiceClass>(reader);
                    return;
                case JsonToken.String:
                case JsonToken.Date:
                    String = serializer.Deserialize<string>(reader);
                    return;
            }
            throw new Exception("Cannot convert ChoiceElement");
        }

        public void WriteJson(JsonWriter writer, JsonSerializer serializer)
        {
            if (AnythingArray != null)
            {
                serializer.Serialize(writer, AnythingArray);
                return;
            }
            if (Bool != null)
            {
                serializer.Serialize(writer, Bool);
                return;
            }
            if (ChoiceClass != null)
            {
                serializer.Serialize(writer, ChoiceClass);
                return;
            }
            if (Double != null)
            {
                serializer.Serialize(writer, Double);
                return;
            }
            if (Integer != null)
            {
                serializer.Serialize(writer, Integer);
                return;
            }
            if (String != null)
            {
                serializer.Serialize(writer, String);
                return;
            }
            writer.WriteNull();
        }
    }

    public partial struct OnlyIfUnion
    {
        public OnlyIfUnion(JsonReader reader, JsonSerializer serializer)
        {
            AnythingArray = null;
            Bool = null;
            Double = null;
            Integer = null;
            OnlyIfClass = null;
            String = null;

            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return;
                case JsonToken.Integer:
                    Integer = serializer.Deserialize<long>(reader);
                    return;
                case JsonToken.Float:
                    Double = serializer.Deserialize<double>(reader);
                    return;
                case JsonToken.Boolean:
                    Bool = serializer.Deserialize<bool>(reader);
                    return;
                case JsonToken.StartArray:
                    AnythingArray = serializer.Deserialize<object[]>(reader);
                    return;
                case JsonToken.StartObject:
                    OnlyIfClass = serializer.Deserialize<OnlyIfClass>(reader);
                    return;
                case JsonToken.String:
                case JsonToken.Date:
                    String = serializer.Deserialize<string>(reader);
                    return;
            }
            throw new Exception("Cannot convert OnlyIfUnion");
        }

        public void WriteJson(JsonWriter writer, JsonSerializer serializer)
        {
            if (AnythingArray != null)
            {
                serializer.Serialize(writer, AnythingArray);
                return;
            }
            if (Bool != null)
            {
                serializer.Serialize(writer, Bool);
                return;
            }
            if (Double != null)
            {
                serializer.Serialize(writer, Double);
                return;
            }
            if (Integer != null)
            {
                serializer.Serialize(writer, Integer);
                return;
            }
            if (OnlyIfClass != null)
            {
                serializer.Serialize(writer, OnlyIfClass);
                return;
            }
            if (String != null)
            {
                serializer.Serialize(writer, String);
                return;
            }
            writer.WriteNull();
        }
    }

    public partial struct ParametersUnion
    {
        public ParametersUnion(JsonReader reader, JsonSerializer serializer)
        {
            AnythingArray = null;
            Bool = null;
            Double = null;
            Integer = null;
            ParametersClass = null;
            String = null;

            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return;
                case JsonToken.Integer:
                    Integer = serializer.Deserialize<long>(reader);
                    return;
                case JsonToken.Float:
                    Double = serializer.Deserialize<double>(reader);
                    return;
                case JsonToken.Boolean:
                    Bool = serializer.Deserialize<bool>(reader);
                    return;
                case JsonToken.StartArray:
                    AnythingArray = serializer.Deserialize<object[]>(reader);
                    return;
                case JsonToken.StartObject:
                    ParametersClass = serializer.Deserialize<ParametersClass>(reader);
                    return;
                case JsonToken.String:
                case JsonToken.Date:
                    String = serializer.Deserialize<string>(reader);
                    return;
            }
            throw new Exception("Cannot convert ParametersUnion");
        }

        public void WriteJson(JsonWriter writer, JsonSerializer serializer)
        {
            if (AnythingArray != null)
            {
                serializer.Serialize(writer, AnythingArray);
                return;
            }
            if (Bool != null)
            {
                serializer.Serialize(writer, Bool);
                return;
            }
            if (Double != null)
            {
                serializer.Serialize(writer, Double);
                return;
            }
            if (Integer != null)
            {
                serializer.Serialize(writer, Integer);
                return;
            }
            if (ParametersClass != null)
            {
                serializer.Serialize(writer, ParametersClass);
                return;
            }
            if (String != null)
            {
                serializer.Serialize(writer, String);
                return;
            }
            writer.WriteNull();
        }
    }

    public partial struct StepElement
    {
        public StepElement(JsonReader reader, JsonSerializer serializer)
        {
            AnythingArray = null;
            Bool = null;
            Double = null;
            Integer = null;
            StepClass = null;
            String = null;

            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return;
                case JsonToken.Integer:
                    Integer = serializer.Deserialize<long>(reader);
                    return;
                case JsonToken.Float:
                    Double = serializer.Deserialize<double>(reader);
                    return;
                case JsonToken.Boolean:
                    Bool = serializer.Deserialize<bool>(reader);
                    return;
                case JsonToken.StartArray:
                    AnythingArray = serializer.Deserialize<object[]>(reader);
                    return;
                case JsonToken.StartObject:
                    StepClass = serializer.Deserialize<StepClass>(reader);
                    return;
                case JsonToken.String:
                case JsonToken.Date:
                    String = serializer.Deserialize<string>(reader);
                    return;
            }
            throw new Exception("Cannot convert StepElement");
        }

        public void WriteJson(JsonWriter writer, JsonSerializer serializer)
        {
            if (AnythingArray != null)
            {
                serializer.Serialize(writer, AnythingArray);
                return;
            }
            if (Bool != null)
            {
                serializer.Serialize(writer, Bool);
                return;
            }
            if (Double != null)
            {
                serializer.Serialize(writer, Double);
                return;
            }
            if (Integer != null)
            {
                serializer.Serialize(writer, Integer);
                return;
            }
            if (StepClass != null)
            {
                serializer.Serialize(writer, StepClass);
                return;
            }
            if (String != null)
            {
                serializer.Serialize(writer, String);
                return;
            }
            writer.WriteNull();
        }
    }

    public static class Serialize
    {
        public static string ToJson(this Template self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal class Converter: JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Generator) || t == typeof(SymbolType) || t == typeof(Precedence) || t == typeof(ShortName) || t == typeof(Ice) || t == typeof(ChoiceElement) || t == typeof(OnlyIfUnion) || t == typeof(ParametersUnion) || t == typeof(StepElement) || t == typeof(Generator?) || t == typeof(SymbolType?) || t == typeof(Precedence?) || t == typeof(ShortName?) || t == typeof(Ice?) || t == typeof(ChoiceElement?) || t == typeof(OnlyIfUnion?) || t == typeof(ParametersUnion?) || t == typeof(StepElement?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (t == typeof(Generator))
                return GeneratorExtensions.ReadJson(reader, serializer);
            if (t == typeof(SymbolType))
                return SymbolTypeExtensions.ReadJson(reader, serializer);
            if (t == typeof(Generator?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return GeneratorExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(SymbolType?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return SymbolTypeExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(Precedence) || t == typeof(Precedence?))
                return new Precedence(reader, serializer);
            if (t == typeof(ShortName) || t == typeof(ShortName?))
                return new ShortName(reader, serializer);
            if (t == typeof(Ice) || t == typeof(Ice?))
                return new Ice(reader, serializer);
            if (t == typeof(ChoiceElement) || t == typeof(ChoiceElement?))
                return new ChoiceElement(reader, serializer);
            if (t == typeof(OnlyIfUnion) || t == typeof(OnlyIfUnion?))
                return new OnlyIfUnion(reader, serializer);
            if (t == typeof(ParametersUnion) || t == typeof(ParametersUnion?))
                return new ParametersUnion(reader, serializer);
            if (t == typeof(StepElement) || t == typeof(StepElement?))
                return new StepElement(reader, serializer);
            throw new Exception("Unknown type");
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var t = value.GetType();
            if (t == typeof(Generator))
            {
                ((Generator)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(SymbolType))
            {
                ((SymbolType)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(Precedence))
            {
                ((Precedence)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(ShortName))
            {
                ((ShortName)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(Ice))
            {
                ((Ice)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(ChoiceElement))
            {
                ((ChoiceElement)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(OnlyIfUnion))
            {
                ((OnlyIfUnion)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(ParametersUnion))
            {
                ((ParametersUnion)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(StepElement))
            {
                ((StepElement)value).WriteJson(writer, serializer);
                return;
            }
            throw new Exception("Unknown type");
        }

        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            Formatting= Formatting.Indented,
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = { 
                new Converter(),
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
