/*
 * MIT License
 * 
 * Copyright (c) 2021 [FacuFalcone]
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

namespace Geometria {
    public class Point {

        #region Attributes

        private int x;
        private int y;

        #endregion

        #region Builder

        /// <summary>
        /// Builds the entity with its points x and y.
        /// </summary>
        /// <param name="x">Point of the entity.</param>
        /// <param name="y">Point of the entity.</param>
        public Point(int x, int y) {
            this.x = x;
            this.y = y;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the axis point.
        /// </summary>
        /// <returns>The axis point.</returns>
        public int GetX() {
            return this.x;
        }

        /// <summary>
        /// Gets the Y point.
        /// </summary>
        /// <returns>The Y point.</returns>
        public int GetY() {
            return this.y;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Assign the vertices of the entity.
        /// </summary>
        /// <param name="x">X vertice to assign.</param>
        /// <param name="y">Y vertice to assign.</param>
        /// <returns>The entity with its vertices assigned.</returns>
        public static Point AssignVertice(Point x, Point y) {
            int axis = x.GetX();
            int yi = y.GetY();
            Point auxiliar = new Point(axis, yi);
            return auxiliar;
        }

        #endregion
    }
}
