namespace geom{
    public class Point{
        private double _x;
        private double _y;

        // PRE: - tingimusi pole
        // POST:
        // X() == x
        // Y() == y
        public Point(double x = 0.0, double y = 0.0){
            _x = x;
            _y = y;
        }

        // rho - kaugus alguspunktist
        // PRE: - tingimusi pole
        // POST:
        // Result == Rho() * cos(Theta())
        public double X(){
            return _x;
        }

        // PRE: - tingimusi pole
        // POST:
        // Result == Rho() * sin(Theta())
        public double Y(){
            return _y;
        }

        // PRE: - tingimusi pole
        // POST:
        // Result == sqrt(X()^2 + Y()^2)
        public double Rho(){
            return Math.Sqrt(X() * X() + Y() * Y());
        }

        // PRE: - tingimusi pole
        // Atan2 sest ta eristab märke x y ees, atan ei erista ja siis nurgad valed.
        // POST:
        // Result == atan2(Y(), X())   (miinusnurgad)
        public double Theta(){
            return Math.Atan2(Y(), X());
        }

        // PRE: - tingimusi pole
        // POST:
        // Result.X() == other.X() - X()
        // Result.Y() == other.Y() - Y()
        public Point VectorTo(Point other){
            return new Point(other.X() - X(), other.Y() - Y());
        }

        // PRE: - tingimusi pole
        // kutsun .rho ja vectorto meetodi siin meetodi sees, et arvuta kaugust
        // POST:
        // Result == VectorTo(other).Rho()
        public double Distance(Point other)
        {
            //double NewX = other.X() - X();
            //double NewY = other.Y() - Y();
            //double length = Math.Sqrt(NewX * NewX + NewY * NewY);
                //return length;
            return VectorTo(other).Rho();
        }

        // liigutame punkti x y kordinaatide võrra
        // PRE: - tingimusi pole
        // POST:
        // X() == old X() + dx
        // Y() == old Y() + dy
        public void Translate(double dx, double dy){
            _x = _x + dx;
            _y = _y + dy;
        }

        // korrutame punkti parameetriga
        // PRE: - tingimusi pole
        // POST:
        // X() == old X() * factor
        // Y() == old Y() * factor
        public void Scale(double factor){
            _x = _x * factor;
            _y = _y * factor;
        }

        
        // ajutised temp muutujad sest muidu esimene rida kirjutaks _x-i üle ja rho väärtus teises reas oleks erinev esimesega
        // PRE: - tingimusi pole
        // POST:
        // Rho() == old Rho() - kaugus 0 punktist ei muutu
        // Theta() == old Theta() + angle
        // (nb! nurkade võrdlus)
        public Point CentreRotate(double angle){
            double tempX = Rho() * Math.Cos(Theta() + angle);
            double tempY = Rho() * Math.Sin(Theta() + angle);
            _x = tempX;
            _y = tempY;

            return this;
        }

        // pööra ümber suvalise punkti
        // PRE: - tingimusi pole
        // POST:
        // p.Distance(this) == p.Distance(old this)
        // p.VectorTo(this).Theta() == p.VectorTo(old this).Theta() + angle   (nb! nurkade võrdlus)
        public void Rotate(Point p2, double angle){
            Translate(-p2.X(), -p2.Y());
            CentreRotate(angle);
            Translate(p2.X(), p2.Y());
        }

        public override string ToString(){
            return $"x: {X():F6}\n" + $"y: {Y():F6}\n" + $"rho: {Rho():F6}\n" + $"theta: {Theta():F6}";
        }
    }
}
