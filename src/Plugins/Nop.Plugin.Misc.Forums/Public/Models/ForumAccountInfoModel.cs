using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;

namespace Nop.Plugin.Misc.Forums.Public.Models;

public record ForumAccountInfoModel : BaseNopModel
{
    #region Properties

    [NopResourceDisplayName("Plugins.Misc.Forums.Account.Signature")]
    public string Signature { get; set; }

    #endregion
}
