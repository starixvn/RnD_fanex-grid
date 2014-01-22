/// <reference path="/Scripts/jasmine-samples/Player.js" />
/// <reference path="/Scripts/jasmine-samples/Song.js" />
/// <reference path="/Scripts/jasmine-samples/SpecHelper.js" />

/// <reference path="./Player.js" />
/// <reference path="./Song.js" />
/// <reference path="./SpecHelper.js" />

describe("Player", function () {
    var player;
    var song;


    beforeEach(function () {
        player = new Player();
        song = new Song();
    });



    it("should be able to play a Song", function () {
        player.play(song);
        expect(player.currentlyPlayingSong).toEqual(song);

        //demonstrates use of custom matcher
        expect(player).toBePlaying(song);
        //expect(0).toEqual(1);
    });



    it("should be played another song", function () {

        player.play(song);

        expect(player.otherSong).toEqual(song);
    });

    describe("when song has been paused", function () {
        beforeEach(function () {
            player.play(song);
            player.pause();
        });

        it("should indicate that the song is currently paused", function () {
            expect(player.isPlaying).toBeFalsy();

            // demonstrates use of 'not' with a custom matcher
            expect(player).not.toBePlaying(song);
        });

        it("should be possible to resume", function () {
            player.resume();
            expect(player.isPlaying).toBeTruthy();
            expect(player.currentlyPlayingSong).toEqual(song);
            expect(true).toEqual(true);
        });
    });

    // demonstrates use of spies to intercept and test method calls
    it("tells the current song if the user has made it a favorite", function () {
        spyOn(song, 'persistFavoriteStatus');

        player.play(song);
        player.makeFavorite();

        expect(song.persistFavoriteStatus).toHaveBeenCalledWith(true);
    });

    //demonstrates use of expected exceptions
    describe("#resume", function () {
        it("should throw an exception if song is already playing", function () {
            player.play(song);

            expect(function () {
                player.resume();
            }).toThrow("song is already playing");
        });
    });
});


describe("Asynchronous specs", function () {
    var value, flag;

    it("should support async execution of test preparation and exepectations", function () {

        runs(function () {
            flag = false;
            value = 0;

            setTimeout(function () {
                flag = true;
            }, 500);
        });

        waitsFor(function () {
            value++;
            return flag;
        },
        "The Value should be incremented",
        750);

        runs(function () {
            expect(value).toBeGreaterThan(0);
            expect(flag).toBe(true);
        });
    });
});


describe("Manually ticking the Jasmine Mock Clock", function () {
    var timerCallback;

    beforeEach(function () {
        timerCallback = jasmine.createSpy('timerCallback');
        jasmine.Clock.useMock();
    });

    it("causes a timeout to be called synchronously", function () {
        setTimeout(function () {
            timerCallback();
        }, 100);

        expect(timerCallback).not.toHaveBeenCalled();

        jasmine.Clock.tick(101);

        expect(timerCallback).toHaveBeenCalled();
    });

    it("causes an interval to be called synchronously", function () {
        setInterval(function () {
            timerCallback();
        }, 100);

        expect(timerCallback).not.toHaveBeenCalled();

        jasmine.Clock.tick(101);
        expect(timerCallback.callCount).toEqual(1);

        jasmine.Clock.tick(50);
        expect(timerCallback.callCount).toEqual(1);

        jasmine.Clock.tick(50);
        expect(timerCallback.callCount).toEqual(2);
    });
});