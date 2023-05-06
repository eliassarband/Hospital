namespace Hospital.Web.BlazorServer.Models
{
    
    public class AccessModel
    {
        public AccessModel Parent { get; set; } = null;

        public int Id { get; set; }
        public string Code { get; set; }
        public AccessNodeType Type { get; set; }
        public string Name { get; set; }

        public bool IsExpanded { get; set; } = false;

        public bool IsChecked { get; set; } = false;

        public bool HasChild => TreeItems != null && TreeItems.Count > 0;

        public HashSet<AccessModel> TreeItems { get; set; } = new HashSet<AccessModel>();

        public AccessModel(int id, string code, AccessNodeType type, string name)
        {
            Id = id;
            Code = code;
            Type = type;
            Name = name;
        }

        public void AddChild(int Id, string Code,AccessNodeType Type,string Name)
        {
            AccessModel item = new AccessModel(Id, Code, Type, Name);
            item.Parent = this;
            this.TreeItems.Add(item);
        }

        public void AddChild(AccessModel accessModel)
        {
            accessModel.Parent = this;
            this.TreeItems.Add(accessModel);
        }

        public bool HasPartialChildSelection()
        {
            int iChildrenCheckedCount = (from c in TreeItems where c.IsChecked select c).Count();
            return HasChild && iChildrenCheckedCount > 0 && iChildrenCheckedCount < TreeItems.Count();
        }

    }

    
}
