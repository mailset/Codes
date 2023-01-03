using System.Threading.Tasks;

namespace TemplateStudioForWinUI.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
