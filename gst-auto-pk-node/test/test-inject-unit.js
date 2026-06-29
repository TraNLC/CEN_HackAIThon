const { encodeField } = require('../src/packet-injector');

console.log('═══════════════════════════════════════');
console.log('  UNIT TEST: Protobuf Encoder');
console.log('═══════════════════════════════════════\n');

// Test 1: int32
const f1 = encodeField(1, 'int32', 35);
console.log('Test 1 (int32 tag 1, value 35):', f1.toString('hex'));
if (f1.toString('hex') === '0823') {
  console.log('  ✅ PASS');
} else {
  console.log('  ❌ FAIL, expected 0823');
}

// Test 2: string
const f2 = encodeField(1, 'string', 'test');
console.log('Test 2 (string tag 1, value "test"):', f2.toString('hex'));
if (f2.toString('hex') === '0a0474657374') {
  console.log('  ✅ PASS');
} else {
  console.log('  ❌ FAIL, expected 0a0474657374');
}

// Test 3: bool
const f3 = encodeField(1, 'bool', true);
console.log('Test 3 (bool tag 1, value true):', f3.toString('hex'));
if (f3.toString('hex') === '0801') {
  console.log('  ✅ PASS');
} else {
  console.log('  ❌ FAIL, expected 0801');
}

console.log('\n═══════════════════════════════════════');
console.log('  UNIT TEST COMPLETE');
console.log('═══════════════════════════════════════');
