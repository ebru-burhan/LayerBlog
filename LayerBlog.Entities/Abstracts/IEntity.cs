using System;
using System.Collections.Generic;
using System.Text;

namespace LayerBlog.Entities.Abstracts
{
    public interface IEntity
    {
        DateTime CreatedDate { get; set; }
        DateTime ModifiedDate { get; set; }
    }
}
