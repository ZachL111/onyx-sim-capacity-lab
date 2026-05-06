# Review Journal

The review surface for `onyx-sim-capacity-lab` is deliberately narrow: one fixture, one scoring rule, and one local check.

The local checks classify each case as `ship`, `watch`, or `hold`. That gives the project a small review vocabulary that matches its simulations focus without claiming live deployment or external usage.

## Cases

- `baseline`: `input pressure`, score 195, lane `ship`
- `stress`: `state drift`, score 151, lane `ship`
- `edge`: `review cost`, score 209, lane `ship`
- `recovery`: `decision risk`, score 199, lane `ship`
- `stale`: `input pressure`, score 233, lane `ship`

## Note

This file is intentionally plain so the fixture remains the source of truth.
