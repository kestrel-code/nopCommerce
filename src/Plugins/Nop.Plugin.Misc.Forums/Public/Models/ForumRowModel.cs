using Nop.Web.Framework.Models;

namespace Nop.Plugin.Misc.Forums.Public.Models;

public record ForumRowModel : BaseNopModel
{
    #region Properties

    public int Id { get; set; }
    public string Name { get; set; }
    public string SeName { get; set; }
    public string Description { get; set; }
    public int NumTopics { get; set; }
    public int NumPosts { get; set; }
    public int LastPostId { get; set; }

    #endregion
}