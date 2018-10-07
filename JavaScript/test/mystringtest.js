var assert = require('assert');
require('../mystring.js');

describe('String polyfill functions', function() {
    describe('startsWith()', function() {
      it('should return true when the string start with \'hang\'', function(){
        assert.equal(true, 'hang the dj'.startsWith('hang'));
      });

      it('should return false when the string not start with \'Hang\'', function(){
        assert.equal(false, 'hang the dj'.startsWith('Hang'));
      });

      it('should return false when the string not start with \'I’ve got a room for rent\'', function(){
        assert.equal(false, 'hang the dj'.startsWith('I’ve got a room for rent'));
      });

      it('should return true when the string start with \'\'', function(){
        assert.equal(true, 'hang the dj'.startsWith(''));
      });

      it('should return true when the string start with \'hang the\'', function(){
        assert.equal(true, 'hang the dj'.startsWith('hang the'));
      });

      it('should return true when the string start with \'han\'', function(){
        assert.equal(true, 'hang the dj'.startsWith('han'));
      });

      it('should return true when the string start with \'hang t\'', function(){
        assert.equal(true, 'hang the dj'.startsWith('hang t'));
      });

      it('should return false when the string not start with 42', function(){
        assert.equal(false, 'hang the dj'.startsWith(42));
      });

      it('should return false when the string not start with { first: \'Johnny\' }', function(){
        assert.equal(false, 'hang the dj'.startsWith({ first: 'Johnny' }));
      });

      it('should return false when the string not start with null', function(){
        assert.equal(false, 'hang the dj'.startsWith(null));
      });      

      it('should return false when the string not start with \'null\'', function(){
        assert.equal(false, 'hang the dj'.startsWith('null'));
      });    

      it('should return false when the string not start with undefined', function(){
        assert.equal(false, 'hang the dj'.startsWith(undefined));
      });    

      it('should return false when the string not start with \'undefined\'', function(){
        assert.equal(false, 'hang the dj'.startsWith('undefined'));
      });  

      it('should return false when the string not start with Nan', function(){
        assert.equal(false, 'hang the dj'.startsWith(Number.Nan));
      });    

      it('should return false when the string not start with \'Nan\'', function(){
        assert.equal(false, 'hang the dj'.startsWith('Nan'));
      });   

      it('should return false when the string not start with false', function(){
        assert.equal(false, 'hang the dj'.startsWith(false));
      });  

      it('should return false when the string not start with 0', function(){
        assert.equal(false, 'hang the dj'.startsWith(0));
      });  

    });

    describe('endsWith()', function() {
        it('should return true when the string end with \'dj\'', function(){
          assert.equal(true, 'hang the dj'.endsWith('dj'));
        });

        it('should return false when the string not end with \'panic on the streets\'', function(){
            assert.equal(false, 'hang the dj'.endsWith('panic on the streets'));
        });

        it('should return true when the string end with \'\'', function(){
            assert.equal(true, 'hang the dj'.endsWith(''));
        });

        it('should return true when the string not end with \'the dj\'', function(){
            assert.equal(true, 'hang the dj'.endsWith('the dj'));
        });

        it('should return true when the string end with \'e dj\'', function(){
            assert.equal(true, 'hang the dj'.endsWith('e dj'));
        });

        it('should return true when the string end with \'j\'', function(){
            assert.equal(true, 'hang the dj'.endsWith('j'));
        });
        
        it('should return false when the string not end with 42', function(){
            assert.equal(false, 'hang the dj'.endsWith(42));
        });
        
        it('should return false when the string not end with { first: \'Johnny\' }', function(){
            assert.equal(false, 'hang the dj'.endsWith({ first: 'Johnny' }));
        });

        it('should return false when the string not end with null', function(){
          assert.equal(false, 'hang the dj'.endsWith(null));
        });      
  
        it('should return false when the string not end with \'null\'', function(){
          assert.equal(false, 'hang the dj'.endsWith('null'));
        });    
  
        it('should return false when the string not end with undefined', function(){
          assert.equal(false, 'hang the dj'.endsWith(undefined));
        });    
  
        it('should return false when the string not end with \'undefined\'', function(){
          assert.equal(false, 'hang the dj'.endsWith('undefined'));
        });  

        it('should return false when the string not end with NaN', function(){
          assert.equal(false, 'hang the dj'.endsWith(Number.Nan));
        });  

        it('should return false when the string not end with \'NaN\'', function(){
          assert.equal(false, 'hang the dj'.endsWith('Nan'));
        });  

        it('should return false when the string not end with false', function(){
          assert.equal(false, 'hang the dj'.endsWith(false));
        });  

        it('should return false when the string not end with 0', function(){
          assert.equal(false, 'hang the dj'.endsWith(0));
        }); 

    });
});
