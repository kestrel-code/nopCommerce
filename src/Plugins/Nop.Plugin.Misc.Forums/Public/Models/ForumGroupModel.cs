using Nop.Web.Framework.Models;

namespace Nop.Plugin.Misc.Forums.Public.Models;

public record ForumGroupModel : BaseNopModel
{
    #region Properties

    public int Id { get; set; }
    public string Name { get; set; }
    public string SeName { get; set; }

    public List<ForumRowModel> Forums { get; set; } = new();

    #endregion
}