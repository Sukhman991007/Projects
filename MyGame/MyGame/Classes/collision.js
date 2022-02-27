function Collision() {
	// remember to add in Top / Bottom / Left / Right object properties in your sprite's JS file
	// call this Function with two sprite object names - e.g. ship and enemy from your html DrawFrame function

	Collision.prototype.Overlapping = function (ObjectA, ObjectB) {
		var L_Overlap,
			R_Overlap,
			T_Overlap,
			B_Overlap;

		L_Overlap = (ObjectA.Left >= ObjectB.Left) & (ObjectA.Left <= ObjectB.Right);
		R_Overlap = (ObjectA.Right >= ObjectB.Left) & (ObjectA.Right <= ObjectB.Right);
		T_Overlap = (ObjectA.Top >= ObjectB.Top) & (ObjectA.Top <= ObjectB.Bottom);
		B_Overlap = (ObjectA.Bottom >= ObjectB.Top) & (ObjectA.Bottom <= ObjectB.Bottom);

		if ((L_Overlap | R_Overlap) & (T_Overlap | B_Overlap)) {
			return true;
		}
		else {
			return false;
		}
	}
}