using System;

namespace Web.Models
{
    public class Dto : IObjectWithState
    {
        public Dto()
        {
            State = Id.HasValue ? State.Unchanged : State.Added;
        }
        public State State { get; set; }
        public Guid? Id { get; set; }
    }
}