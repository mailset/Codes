﻿using System.Threading.Tasks;

namespace TemplateStudioForWinUI.Activation;

public interface IActivationHandler
{
    bool CanHandle(object args);

    Task HandleAsync(object args);
}
