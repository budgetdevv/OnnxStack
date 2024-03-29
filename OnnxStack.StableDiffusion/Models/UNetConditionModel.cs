using OnnxStack.Core.Config;
using OnnxStack.Core.Model;
using OnnxStack.StableDiffusion.Enums;

namespace OnnxStack.StableDiffusion.Models
{
    public class UNetConditionModel : OnnxModelSession
    {
        private readonly ModelType _modelType;

        private readonly bool _minMemoryModeShouldUnloadModel;
        
        public UNetConditionModel(UNetConditionModelConfig configuration) : base(configuration)
        {
            _modelType = configuration.ModelType;
            _minMemoryModeShouldUnloadModel = configuration.MinMemoryModeShouldUnloadModel;
        }

        public ModelType ModelType => _modelType;
        
        public bool MinMemoryModeShouldUnloadModel => _minMemoryModeShouldUnloadModel;
    }


    public record UNetConditionModelConfig : OnnxModelConfig
    {
        public ModelType ModelType { get; set; }

        public bool MinMemoryModeShouldUnloadModel { get; set; }
    }
}
