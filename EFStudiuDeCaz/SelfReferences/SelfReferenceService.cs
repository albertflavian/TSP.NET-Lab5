using System.Collections.Generic;
using System.Linq;

namespace EFStudiuDeCaz.SelfReferences
{
    class SelfReferenceService
    {
        private readonly ModelSelfReferences _dbContext;
        public SelfReferenceService(ModelSelfReferences context)
        {
            this._dbContext = context;
        }

        public void Add(SelfReference self)
        {
            _dbContext.SelfReferences.Add(self);
            _dbContext.SaveChanges();
        }
        public void AddReference(SelfReference self, SelfReference parent)
        {
            var t_self = _dbContext.SelfReferences
                .Where(a => a.SelfReferenceId == self.SelfReferenceId)
                .FirstOrDefault();
            t_self.ParentSelfReference = parent;
            var t_parent = _dbContext.SelfReferences
                .Where(a => a.SelfReferenceId == parent.SelfReferenceId)
                .FirstOrDefault();
            t_parent.References.Add(self);
            _dbContext.SaveChanges();

        }
        public List<SelfReference> GetAll()
        {
            return _dbContext.SelfReferences.ToList();
        }

        
    }
}
