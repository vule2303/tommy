var myInfo = {
    name:'Son Dang',
    age: 18,
    address: 'HaNoi, VN'
};
for (var value of Object.values(myInfo)) {
    console.log(value);
}

for (var value of Object.keys(myInfo)) {
    console.log(value);
}
