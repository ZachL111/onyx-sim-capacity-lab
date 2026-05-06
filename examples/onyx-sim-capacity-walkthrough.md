# Onyx Sim Capacity Lab Walkthrough

This note is the quickest way to read the extra review model in `onyx-sim-capacity-lab`.

| Case | Focus | Score | Lane |
| --- | --- | ---: | --- |
| baseline | input pressure | 195 | ship |
| stress | state drift | 151 | ship |
| edge | review cost | 209 | ship |
| recovery | decision risk | 199 | ship |
| stale | input pressure | 233 | ship |

Start with `stale` and `stress`. They create the widest contrast in this repository's fixture set, which makes them better review anchors than the middle cases.

`stale` is the optimistic case; use it to make sure the scoring path still rewards strong signal.
