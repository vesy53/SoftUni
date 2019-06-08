namespace p04._01.Froggy
{
    using System.Collections;
    using System.Collections.Generic;

    public class Lake<T> : IEnumerable<T>
    {
        private IList<T> jumpingFrog;

        public Lake(params T[] jumpingFrog)
        {
            this.jumpingFrog = new List<T>(jumpingFrog);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.jumpingFrog.Count; i++)
            {
                if (i % 2 == 0)
                {
                    yield return this.jumpingFrog[i];
                }
            }

            for (int i = this.jumpingFrog.Count - 1; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    yield return this.jumpingFrog[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
