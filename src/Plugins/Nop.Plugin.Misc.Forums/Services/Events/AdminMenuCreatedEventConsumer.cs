using Nop.Services.Events;
using Nop.Services.Localization;
using Nop.Web.Framework.Events;

namespace Nop.Plugin.Misc.Forums.Services.Events;

/// <summary>
/// Represents the plugin event consumer
/// </summary>
public class AdminMenuCreatedEventConsumer : IConsumer<AdminMenuCreatedEvent>
{
    #region Fields

    private readonly ILocalizationService _localizationService;
    private readonly ForumSettings _forumSettings;

    #endregion

    #region Ctor

    public AdminMenuCreatedEventConsumer(ILocalizationService localizationService, ForumSettings forumSettings)
    {
        _localizationService = localizationService;
        _forumSettings = forumSettings;
    }

    #endregion

    #region Methods

    /// <summary>
    /// Handle admin menu created event
    /// </summary>
    /// <param name="eventMessage">Event message</param>
    /// <returns>A task that represents the asynchronous operation</returns>
    public async Task HandleEventAsync(AdminMenuCreatedEvent eventMessage)
    {
        if (!_forumSettings.ForumsEnabled)
            return;

        eventMessage.RootMenuItem.InsertAfter("Message templates", new()
        {
            SystemName = "Manage forums",
            Title = await _localizationService.GetResourceAsync("Plugins.Misc.Forums"),
            PermissionNames = new List<string> { ForumDefaults.Permissions.FORUMS_VIEW },
            Url = eventMessage.GetMenuItemUrl("Forum", "List"),
            IconClass = "far fa-dot-circle"
        });
    }

    #endregion
}