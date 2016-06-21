height = 4000;
angle = 10;
spacing = 2000;

translations = [ [0,0], [0,-1], [1,-1], [1,0] ];
angles = [ [1,1], [-1,1], [-1,-1], [1,-1] ];
colours = [ [], [], [], [] ]

for (i = [0:3]) {
    translate([-1000+translations[i][0]*spacing,1000+translations[i][1]*spacing,0]) {
        translate([0,0,1000]) {
            rotate([]) {
                cylinder(h=2000,d=100);
            }
        }
        rotate([angle*angles[i][0],angle*angles[i][1],0]) {
            cylinder(h=height,d=100);
        }
    }
}