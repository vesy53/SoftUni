namespace p04._02.Froggy
{
    using System.Collections;
    using System.Collections.Generic;

    public class Lake : IEnumerable<int>
    {
        private readonly IList<int> jumpingFrog;

        public Lake(IEnumerable<int> jumpingFrog)
        {
            this.jumpingFrog = new List<int>(jumpingFrog);
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.jumpingFrog.Count; i += 2)
            {
                yield return this.jumpingFrog[i];
            }

            int length = this.jumpingFrog.Count % 2 == 0 ?
                this.jumpingFrog.Count - 1 :
                this.jumpingFrog.Count - 2;

            for (int i = length; i >= 0; i -= 2)
            {
                yield return this.jumpingFrog[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
