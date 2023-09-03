namespace DesignPatterns.Structural.Composite
{
    public class Group : IComponent
    {

        private readonly List<IComponent> _components=new List<IComponent>();


        public void Add(IComponent component)
        {
            _components.Add(component);
        }

        public void Render()
        {
            foreach (var component in _components)
            {
                component.Render();
            }
        }

        public void Move()
        {
            foreach (var component in _components)
            {
                component.Move();
            }
        }
    }
}
